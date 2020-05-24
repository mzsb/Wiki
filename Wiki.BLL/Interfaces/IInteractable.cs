using System;
using System.Collections.Generic;
using System.Text;
using Wiki.BLL.Commands;

namespace Wiki.BLL.Interfaces
{
    public interface IInteractable 
    {
        DelegateCommand Command { get; set; }
    }
}
