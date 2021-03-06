﻿namespace CSharp
{
    using System;
    using System.Text;

    public static class Messages
    {
        private static readonly StringBuilder Output = new StringBuilder();

        public static string OutputString
        {
            get
            {
                return Output.ToString();
            }
        }

        public static void EventAdded()
        {
            Output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int amount)
        {
            if (amount == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted{1}", amount, Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}