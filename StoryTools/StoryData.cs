using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTools
{
    internal class StoryData
    {
        private string speakerKey;   //说话者，key，对应 localizationNpc 中的 key
        private string speakerValue;
        private string dialogKey;    //文本内容
        private string dialogValue;
        private int speed;        //文本显示速度
        private int protectTime;  //保护时间系数
        private string anime;     //Unknown function
        private float start;      //Unknown function
        private float count;      //Unknown function
    }
}
