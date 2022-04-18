using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventTests
{
    //Bu sınıfı custom paremetre geçirmek için kullanıyoruz
    public class ButtonPressedEventArgs
    {
        public ButtonPressedEventArgs(char keyCode)
        {
            KeyCode = keyCode;
        }
        public char KeyCode { get;}
    }
}
