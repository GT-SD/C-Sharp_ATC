
namespace WindowsFormsApplication8
{
    public class Сonversation
    {
        public Сonversation(string da, string du, string callT, string сallerN, string сalledN) 
        {
            date = da;
            duration = du; 
            callType = callT;
            callerNumber = сallerN;
            сalledNumber = сalledN;
        }
        string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        string callType;
        public string CallType
        {
            get { return callType; }
            set { callType = value; }
        }
        string callerNumber;
        public string CallerNumber
        {
            get { return callerNumber; }
            set { callerNumber = value; }
        }
        string сalledNumber;
        public string CalledNumber
        {
            get { return сalledNumber; }    
            set { сalledNumber = value; }
        }      
    }
}
