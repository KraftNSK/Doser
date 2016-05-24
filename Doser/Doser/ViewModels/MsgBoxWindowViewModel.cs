using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doser.Utility;

namespace Doser.ViewModels
{

    public class MsgBoxWindowViewModel: ViewModelBase
    {
        public MsgBoxWindowViewModel()
        {
        }

        public MsgBoxWindowViewModel(string title, string message)
        {
            Title = title;
            Message = message;
        }

        public string Title { get; set; }
        public string Message { get; set; }

    }
}
