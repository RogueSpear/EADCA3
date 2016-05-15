using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAuthor_Code" in both code and config file together.
    [ServiceContract]
    public interface IServiceAuthor_Code
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Contacts ReturnAuthor();
    }
}
