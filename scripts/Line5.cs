
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace SpringFramework55.UI
{

    /// <summary>
    /// 函数图基础 XY轴 刻度等
    /// </summary>
    [Serializable]
    public class FunctionSetX5
    {
        // public static float x;
        public static float x5;
        public static VertexHelper vh25;
        public static FunctionalGraphBase5 GraphBase5 = new FunctionalGraphBase5();
        public static List<FunctionFormula5> Formulas5;
        public static RectTransform _myRect5;
    }
    public class FunctionalGraphBase5
    {
        /// <summary>
        /// 是否显示刻度
        /// </summary>
        public bool ShowScale5 = false;

        /// <summary>
        /// XY轴刻度
        /// </summary>
        [Range(20f, 100f)] public float ScaleValue5 = 50f;
        /// <summary>
        /// 刻度的长度
        /// </summary>
        [Range(2, 10)] public float ScaleLenght5 = 5.0f;
        /// <summary>
        /// XY轴宽度
        /// </summary>
        [Range(2f, 20f)] public float XYAxisWidth5 = 2.0f;
        /// <summary>
        /// XY轴颜色
        /// </summary>

    }

    /// <summary>
    /// 函数公式
    /// </summary>
    [Serializable]
    public class FunctionFormula5
    {
        /// <summary>
        /// 函数表达式
        /// </summary>
        public Func<float, float> Formula5;
        /// <summary>
        /// 函数图对应线条颜色
        /// </summary>
        public Color FormulaColor5;
        public float FormulaWidth5;

        public FunctionFormula5() { }
        public FunctionFormula5(Func<float, float> formula, Color formulaColor, float width)
        {
            Formula5 = formula;
            FormulaColor5 = formulaColor;
            FormulaWidth5 = width;
        }

        public Vector2 GetResult(float xValue, float scaleValue)
        {
            return new Vector2(xValue, Formula5(xValue / scaleValue) * scaleValue);
        }
    }


    public class Line5 : MaskableGraphic
    {
        public FunctionalGraphBase5 GraphBase5 = new FunctionalGraphBase5();
        public List<FunctionFormula5> Formulas5;
        private RectTransform _myRect5;
        private Vector2 _xPoint;
        private Vector2 _yPoint;


        /// <summary>
        /// 初始化函数信息
        /// </summary>
        public void Init()
        {
            _myRect5 = this.rectTransform;
            Formulas5 = new List<FunctionFormula5>
            {
             //  new FunctionFormula(Mathf.Sin, Color.red, 2.0f),
                            //  new FunctionFormula2(xValue=>-6/5*xValue*xValue*xValue +3*xValue *xValue ,Color.green,2.0f)
              new FunctionFormula5(xValue=>1 ,Color.red ,2.0f)
            };
        }

        /// <summary>
        /// 重写这个类以绘制UI
        /// </summary>
        /// <param name="vh"></param>
        protected override void OnPopulateMesh(VertexHelper vh)
        {
            Init();
            vh.Clear();
            FunctionSetX5.vh25 = vh;


            #region 函数图的绘制
            FunctionSetX5._myRect5 = _myRect5;
            FunctionSetX5.GraphBase5 = GraphBase5;
            FunctionSetX5.Formulas5 = Formulas5;
            drawline();

            #endregion
        }

        public static void drawline()
        {
            //FunctionSetX._myRect;
            //FunctionSetX.GraphBase = new FunctionalGraphBase();
            //FunctionSetX.vh2.Clear();//坐标轴

            // Debug.Log("this is in drawline of x!" + FunctionSetX2.Formulas2.ToString());
            float unitPixel = 100 / FunctionSetX5.GraphBase5.ScaleValue5;
            foreach (var functionFormula in FunctionSetX5.Formulas5)
            {
                //FunctionSetX.x
                Vector2 startPos = functionFormula.GetResult(0, FunctionSetX5.GraphBase5.ScaleValue5);
                for (float x = -FunctionSetX5._myRect5.sizeDelta.x / 50.0f + 10; x < FunctionSetX5.x5 + 10 / 2.0f; x += unitPixel)
                {
                    Vector2 endPos = functionFormula.GetResult(x, FunctionSetX5.GraphBase5.ScaleValue5);
                    FunctionSetX5.vh25.AddUIVertexQuad(Line5.GetQuad(startPos, endPos, functionFormula.FormulaColor5, functionFormula.FormulaWidth5));
                    startPos = endPos;
                }
            }
            //Debug.Log("this is in drawline2!");
        }

        //通过两个端点绘制矩形
        public static UIVertex[] GetQuad(Vector2 startPos, Vector2 endPos, Color color0, float lineWidth = 2.0f)
        {
            float dis = Vector2.Distance(startPos, endPos);
            float y = lineWidth * 0.5f * (endPos.x - startPos.x) / dis;
            float x = lineWidth * 0.5f * (endPos.y - startPos.y) / dis;
            if (y <= 0) y = -y;
            else x = -x;
            UIVertex[] vertex = new UIVertex[4];
            vertex[0].position = new Vector3(startPos.x + x, startPos.y + y);
            vertex[1].position = new Vector3(endPos.x + x, endPos.y + y);
            vertex[2].position = new Vector3(endPos.x - x, endPos.y - y);
            vertex[3].position = new Vector3(startPos.x - x, startPos.y - y);
            for (int i = 0; i < vertex.Length; i++) vertex[i].color = color0;
            return vertex;
        }

        //通过四个顶点绘制矩形
        private UIVertex[] GetQuad(Vector2 first, Vector2 second, Vector2 third, Vector2 four, Color color0)
        {
            UIVertex[] vertexs = new UIVertex[4];
            vertexs[0] = GetUIVertex(first, color0);
            vertexs[1] = GetUIVertex(second, color0);
            vertexs[2] = GetUIVertex(third, color0);
            vertexs[3] = GetUIVertex(four, color0);
            return vertexs;
        }

        //构造UIVertex
        private UIVertex GetUIVertex(Vector2 point, Color color0)
        {
            UIVertex vertex = new UIVertex
            {
                position = point,
                color = color0,
                uv0 = new Vector2(0, 0)
            };
            return vertex;
        }


        //本地坐标转化屏幕坐标绘制GUI文字
        private Vector2 local2Screen(Vector2 parentPos, Vector2 localPosition)
        {
            Vector2 pos = localPosition + parentPos;
            float xValue, yValue = 0;
            if (pos.x > 0)
                xValue = pos.x + Screen.width / 2.0f;
            else
                xValue = Screen.width / 2.0f - Mathf.Abs(pos.x);
            if (pos.y > 0)
                yValue = Screen.height / 2.0f - pos.y;
            else
                yValue = Screen.height / 2.0f + Mathf.Abs(pos.y);
            return new Vector2(xValue, yValue);
        }

        //递归计算位置
        private Vector2 getScreenPosition(Transform trans, ref Vector3 result)
        {
            if (null != trans.parent && null != trans.parent.parent)
            {
                result += trans.parent.localPosition;
                getScreenPosition(trans.parent, ref result);
            }
            if (null != trans.parent && null == trans.parent.parent)
                return result;
            return result;
        }
    }
}
