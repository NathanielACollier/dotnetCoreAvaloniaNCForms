namespace TestApp.model
{
    public class DataContext_HelloWorld: nac.Forms.model.ViewModelBase
    {
        public string Message
        {
            get { return GetValue(() => Message); }
            set { SetValue(() => Message, value);}
        }
    }
}