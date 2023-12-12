
namespace System.Windows.Forms
{
    /// <summary>
    /// To sovle double click can not invoke in Button 
    /// </summary>
    public class DoubleClickButton : Button 
    {
        public DoubleClickButton(): base()
        {
            SetStyle(ControlStyles.StandardClick, true);
            SetStyle(ControlStyles.StandardDoubleClick, true);
        }
	}
}
