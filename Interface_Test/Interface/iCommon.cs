using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Test
{
    interface iCommon
    {
        /// <summary>
        ///  Form Name 작성
        /// </summary>
        string strFormName { get; set; }

        /// <summary>
        /// 초기화 시 호출 한 Fomr Name
        /// </summary>
        void fInit();
        
        /// <summary>
        /// 사용자가 선택한 색상을 기준으로 테마 변경
        /// </summary>
        /// <param name="color">변경 할 색상</param>
        void fColorChange(Color color);
    }
}
