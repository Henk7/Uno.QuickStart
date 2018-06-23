using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class TestMeModel : INotifyPropertyChanged
    {
        public TestMeModel()
        {
            this.TestMe = "zzzzzzzz";
            //Task.Delay(4000).ContinueWith(t => AsyncUIContext.Current.InvokeAsync(() => this.TestMe = "uuuuuuuu"));
        }

        private string _TestMe;
        public string TestMe
        {
            get { return this._TestMe; }
            set
            {
                if (this._TestMe != value)
                {
                    this._TestMe = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TestMe)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
