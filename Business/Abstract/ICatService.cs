using Entities;

namespace Business.Abstract
{
    public interface ICatService
    {
        Cat Size();
        Cat Color();
        Cat Feature(string feature);
        Cat Leg(int leg);
    }
}