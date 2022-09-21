using HeyCommit.Client.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace HeyCommit.Client.Main.ViewModel
{
    public class MainViewModel : MvvmBase
    {
        public Brush OnBackground { get; set; } = Brushes.White;
        public Brush OnForeground { get; set; } = Brushes.Black;
        public Brush OffBackground { get; set; } = Brushes.White;
        public Brush OffForeground { get; set; } = Brushes.Black;

        public string GitId { get; set; }
        public string GitToken { get; set; }
        public string BotToken { get; set; }
        public string ChannelId { get; set; }
        public string BotText { get; set; }
        private bool textBoxIsEnabled;
        public bool TextBoxIsEnabled 
        {
            get => textBoxIsEnabled;
            set 
            {
                textBoxIsEnabled = value;
                NotifyPropertyChanged("TextBoxIsEnabled");
            }
        }

        private bool onIsChecked;
        public bool OnIsChecked 
        {
            get => onIsChecked;
            set 
            {
                onIsChecked = value;
                if (onIsChecked) 
                {
                    TextBoxIsEnabled = false;
                }
                NotifyPropertyChanged("OnIsChecked");
            }
        }
        private bool offIsChecked;
        public bool OffIsChecked
        {
            get => offIsChecked;
            set
            {
                offIsChecked = value;
                if (offIsChecked) 
                {
                    TextBoxIsEnabled = true;
                }
                NotifyPropertyChanged("OffIsChecked");
            }
        }
        public MainViewModel()
        {
           
        }
    }
}
