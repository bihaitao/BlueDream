using System.Drawing;
using System.Drawing.Imaging;

namespace BlueDream.WebApi
{
    public static class VerifyCodeHelper
    {
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="n">验证码数</param>
        /// <param name="type">类型 0：数字 1：字符</param>
        /// <returns></returns>
        public static VerifyCode CreateVerifyCode(int n, VerifyCodeType type)
        {
            //宽、高，字体大小
            int codeW = 74;
            int codeH = 36;
            int fontSize = 16;

            //初始化验证码
            string charCode = string.Empty;

            switch (type.ToString())
            {
                case "NUM":
                    charCode = CreateNumCode(n);
                    break;
                default:
                    charCode = CreateCharCode(n);
                    break;
            }

            //颜色列表
            Color[] colors = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Brown, Color.DarkBlue };

            //字体列表
            string[] fonts = { "Times New Roman", "Verdana", "Arial", "Gungsuh" };

            //创建画布
            Bitmap bitmap = new Bitmap(codeW, codeH);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            Random random = new Random();

            //画躁线
            for (int i = 0; i < n; i++)
            {
                int x1 = random.Next(codeW);
                int y1 = random.Next(codeH);
                int x2 = random.Next(codeW);
                int y2 = random.Next(codeH);
                Color color = colors[random.Next(colors.Length)];
                Pen pen = new Pen(color);
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }

            //画噪点
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(codeW);
                int y = random.Next(codeH);
                Color color = colors[random.Next(colors.Length)];
                bitmap.SetPixel(x, y, color);
            }

            //画验证码
            for (int i = 0; i < n; i++)
            {
                string fontStr = fonts[random.Next(fonts.Length)];
                Font font = new Font(fontStr, fontSize);
                Color color = colors[random.Next(colors.Length)];
                graphics.DrawString(charCode[i].ToString(), font, new SolidBrush(color), (float)i * 15 + 2, (float)0);
            }

            //写入内存流
            try
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Jpeg);

                VerifyCode verifyCode = new VerifyCode()
                {
                    Code = charCode,
                    Image = stream.ToArray()
                };
                return verifyCode;
            }

            //释放资源
            finally
            {
                graphics.Dispose();
                bitmap.Dispose();
            }

        }

        /// <summary>
        /// 获取数字验证码
        /// </summary>
        /// <param name="n">验证码数</param>
        /// <returns></returns>
        public static string CreateNumCode(int n)
        {
            char[] numChar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string charCode = string.Empty;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                charCode += numChar[random.Next(numChar.Length)];
            }
            return charCode;
        }

        /// <summary>
        /// 获取字符验证码
        /// </summary>
        /// <param name="n">验证码数</param>
        /// <returns></returns>
        public static string CreateCharCode(int n)
        {
            char[] strChar = { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3',
                '4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K',
                'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            string charCode = string.Empty;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                charCode += strChar[random.Next(strChar.Length)];
            }
            return charCode;
        }
    }
}
