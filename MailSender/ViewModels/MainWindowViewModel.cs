using MailSender.lib.ViewModels.Base;
using MailSender.Models;
using MailSender.Models.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailSender.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Рассыльщик";

        public string Title { get => _Title; set => Set(ref _Title, value); }

        private string _Status = "Готов!";

        public string Status { get => _Status; set => Set(ref _Status, value); }

    }
}
