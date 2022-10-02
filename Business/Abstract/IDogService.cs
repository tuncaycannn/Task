using Entities;

namespace Business.Abstract
{
    public interface IDogService
    {
        Dog Size();
        Dog Color();
        Dog Feature(string feature);
        Dog Leg(int size);
    }
}