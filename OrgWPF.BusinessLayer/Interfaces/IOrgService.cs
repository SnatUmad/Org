using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OrgWPF.BusinessLayer.Models;

namespace OrgWPF.BusinessLayer.Interfaces
{
    public interface IOrgService<T>
    {
        ObservableCollection<T> GetAll();
        T Get(int id);
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
