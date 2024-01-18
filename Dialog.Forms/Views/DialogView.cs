using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Dialog.Forms.Views
{
    public class DialogView : JamesContent
    {
        static DialogView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DialogView), new FrameworkPropertyMetadata(typeof(DialogView)));
        }

        public DialogView()
        {
            //인스턴스 생성
        }
    }
}
