using System;
using System.Collections.Generic;
using WorkGroup;

namespace UserDefs
{
    abstract class AllUser
    {
        public int localUserID { get; set; }
        public string UserName { get; set; }
    
        public double localUserTimeZome { get; set; }
        public List<int> userDefGroups { get; set; }
        public int[] skillsList { get; set; }


        private int _startTime;
        private int _endTime;


        
        private int _currentWorking;
        private int[] _workingGroupsID;


    /// <summary>
    /// This may be moved later. 
    /// </summary>
    public enum TimeZone
        {
            gmt0,
            gmt1,
            gmt2,
            gmt3,
        }


        public enum PushType
        {
            debug,
            ProdDB,
            DebugDB,
            XMlFile,
        }


        /// <summary>
        /// This will collect the percent of time left in the users stated working day, this will grab the current time and use the start time of the user to calculte the
        /// how much of they day has passed
        /// </summary>
        /// <returns></returns>
        public double PercentTimeFile()
        {
            double timeFilled = 0;
            string currentTime = DateTime.Now.ToString("HH:mm");
            string newtime = currentTime.Replace(":", "");
            int cTime = int.Parse(newtime);

            if (UserAtWork())
            {
                timeFilled = (((double)cTime - (double)_startTime)) / ((double)_endTime - (double)_startTime);
                Console.WriteLine(cTime - _startTime);
                Console.WriteLine(_endTime - _startTime);
                Console.WriteLine(timeFilled);
            }
            return timeFilled;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupId"></param>
        public void ChangeCurrentGroup(int groupId)
        {

        }

        /// <summary>
        /// Shows that the current time is outside the user work day 
        /// </summary>
        /// <returns></returns>
        public bool UserAtWork()
        {
            bool atWork;
            string currentTime = DateTime.Now.ToString("HH:mm");
            string newtime = currentTime.Replace(":", "");

            int iStr = int.Parse(newtime);

            if (iStr > startTime && iStr < endTime)
            {
                atWork = true;
            }
            else
            {
                atWork = false;
            }

            return atWork;
        }


        public bool PushUserData(PushType pt)
        {
            bool successfullPush = false;

            switch (pt)
            {
                case (PushType.XMlFile):
                    successfullPush = PushUserDataToXMLFile();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return successfullPush;
        }




        /// <summary>
        /// Pushes 
        /// </summary>
        /// <returns></returns>
        private bool PushUserDataToDB()
        {
            bool successfullPushToDB = false;


            return successfullPushToDB;
        }


        /// <summary>
        /// This will be pushed to a local xml file containing the users data, this will be usefull so a pull is not needced from the db as the time
        /// </summary>
        /// <returns></returns>
        public bool PushUserDataToXMLFile()
        {
            bool successfullPushToDB = false;


            return successfullPushToDB;
        }



    }
}