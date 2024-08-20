using DebraEventAPI.Models;
namespace DebraEventAPI.Data
{
    public interface IPartnerRepo
    {
        bool Save();
        Partner GetPartner(int id);
        bool CreatePartner(Partner partner);
        bool UpdatePartner(Partner partner);
        bool DeletePartner(Partner partner);

        Partner Login(string email, string password);
        IEnumerable<Partner> GetAllPartners();
    }
}
