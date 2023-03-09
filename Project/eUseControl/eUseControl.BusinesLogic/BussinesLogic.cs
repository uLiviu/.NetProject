using eUseControl.BusinesLogic.Interfaces;

namespace eUseControl.BusinesLogic;
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }

}