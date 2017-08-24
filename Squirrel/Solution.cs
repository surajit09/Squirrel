using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirrel
{
    internal class Solution
    {
        public static void Run(List<Entry> log)
        {
			
			Int32 logCount = 0;
			List<string> allEvents=new List<string>();
			foreach (Entry aLog in log)
			{
				if (aLog.Squirrel)
				{
					//Get the array that contains biggest number of events. 
					if (aLog.Events.Count > logCount)
						logCount = aLog.Events.Count;
					allEvents = aLog.Events;
					
				}
				
			}

			// Get log entries where Squirrel=true
			List<Entry> filteredLog = new List<Entry>();
			filteredLog = log.FindAll(x=>x.Squirrel);

			//Check which event is present in all cases where Squirrel=true
			foreach (string elm in allEvents)
			{

				if (filteredLog.All(x => x.Events.Exists(y => y == elm))) {

					Console.WriteLine(elm);
				}


			}

			//The conclusion : Jacque is turning into squirrel by eating peanuts!!



		}
	}
}