
using BlImplementation;

namespace BlApi;

    public static class Factory
    {
        public static IBl Get()
        {
            IBl Bl = new Bl();
            return Bl;
        }
    }




