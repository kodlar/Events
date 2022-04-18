namespace ConsoleAppEventTests
{
    public class ButtonMaster
    {
        public event EventHandler<ButtonPressedEventArgs>? ButtonPressed;
        public void OnButtonPressed(char keyCode)
        {
            //ButtonPressed?.Invoke(this, EventArgs.Empty);
            ButtonPressed?.Invoke(this, new ButtonPressedEventArgs(keyCode));
        }
    }
}
