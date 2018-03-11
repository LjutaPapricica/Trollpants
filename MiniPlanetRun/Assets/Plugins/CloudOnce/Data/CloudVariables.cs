// <copyright file="CloudVariables.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
    using CloudPrefs;

    /// <summary>
    /// Provides access to cloud variables registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class CloudVariables
    {
        private static readonly CloudBool s_askedToRate = new CloudBool("AskedToRate", PersistenceType.Highest, false);

        public static bool AskedToRate
        {
            get { return s_askedToRate.Value; }
            set { s_askedToRate.Value = value; }
        }

        private static readonly CloudBool s_hasSeenTutorial = new CloudBool("HasSeenTutorial", PersistenceType.Highest, false);

        public static bool HasSeenTutorial
        {
            get { return s_hasSeenTutorial.Value; }
            set { s_hasSeenTutorial.Value = value; }
        }

        private static readonly CloudInt s_highScore = new CloudInt("HighScore", PersistenceType.Highest, 0);

        public static int HighScore
        {
            get { return s_highScore.Value; }
            set { s_highScore.Value = value; }
        }

        private static readonly CloudInt s_totalCollectedCherries = new CloudInt("TotalCollectedCherries", PersistenceType.Highest, 0);

        public static int TotalCollectedCherries
        {
            get { return s_totalCollectedCherries.Value; }
            set { s_totalCollectedCherries.Value = value; }
        }

        private static readonly CloudInt s_totalThingsDodged = new CloudInt("TotalThingsDodged", PersistenceType.Highest, 0);

        public static int TotalThingsDodged
        {
            get { return s_totalThingsDodged.Value; }
            set { s_totalThingsDodged.Value = value; }
        }

        private static readonly CloudCurrencyInt s_cherries = new CloudCurrencyInt("Cherries", 0, false);

        public static int Cherries
        {
            get { return s_cherries.Value; }
            set { s_cherries.Value = value; }
        }

        private static readonly CloudBool s_char2Unlocked = new CloudBool("Char2Unlocked", PersistenceType.Highest, false);

        public static bool Char2Unlocked
        {
            get { return s_char2Unlocked.Value; }
            set { s_char2Unlocked.Value = value; }
        }

        private static readonly CloudBool s_char3Unlocked = new CloudBool("Char3Unlocked", PersistenceType.Highest, false);

        public static bool Char3Unlocked
        {
            get { return s_char3Unlocked.Value; }
            set { s_char3Unlocked.Value = value; }
        }

        private static readonly CloudBool s_char4Unlocked = new CloudBool("Char4Unlocked", PersistenceType.Highest, false);

        public static bool Char4Unlocked
        {
            get { return s_char4Unlocked.Value; }
            set { s_char4Unlocked.Value = value; }
        }

        private static readonly CloudBool s_char5Unlocked = new CloudBool("Char5Unlocked", PersistenceType.Highest, false);

        public static bool Char5Unlocked
        {
            get { return s_char5Unlocked.Value; }
            set { s_char5Unlocked.Value = value; }
        }

        private static readonly CloudBool s_char6Unlocked = new CloudBool("Char6Unlocked", PersistenceType.Highest, false);

        public static bool Char6Unlocked
        {
            get { return s_char6Unlocked.Value; }
            set { s_char6Unlocked.Value = value; }
        }
    }
}
