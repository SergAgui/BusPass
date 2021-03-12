using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Models
{
    public interface IRepository
    {
        PriceModel FindPriceId(int id);
        void NewPrice(PriceModel price);
        void UpdatePrice(int id);
        void RemovePrice(int id);
        
        FareModel FindFareId(int id);
        void NewFare(FareModel fare);
        void UpdateFare(int id);
        void RemoveFare(int id);

        ServiceAlertModel FindAlertId(int id);
        void NewAlert(ServiceAlertModel serviceAlert);
        void RemoveAlert(int id);

        UserModel FindUserId(int id);
        void NewUser(UserModel user);
        void RemoveUser(int id);
        void UpdateUser(int id);
    }
}
