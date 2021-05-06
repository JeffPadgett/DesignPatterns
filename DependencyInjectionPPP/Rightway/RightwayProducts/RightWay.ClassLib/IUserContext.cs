namespace Rightway.ClassLib
{
    public enum Role { PreferredCustomer }

    public interface IUserContext
    {
        bool IsInRole(Role role);
    }

}