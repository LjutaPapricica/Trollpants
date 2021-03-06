// <copyright file="Achievements.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
    using Internal;

    /// <summary>
    /// Provides access to achievements registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class Achievements
    {
        private static readonly UnifiedAchievement s_fullDeck = new UnifiedAchievement("FullDeck",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "FullDeck"
#endif
            );

        public static UnifiedAchievement FullDeck
        {
            get { return s_fullDeck; }
        }

        private static readonly UnifiedAchievement s_gambler = new UnifiedAchievement("Gambler",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "Gambler"
#endif
            );

        public static UnifiedAchievement Gambler
        {
            get { return s_gambler; }
        }

        private static readonly UnifiedAchievement s_highRoller = new UnifiedAchievement("HighRoller",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "HighRoller"
#endif
            );

        public static UnifiedAchievement HighRoller
        {
            get { return s_highRoller; }
        }

        private static readonly UnifiedAchievement s_lucky = new UnifiedAchievement("Lucky",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "Lucky"
#endif
            );

        public static UnifiedAchievement Lucky
        {
            get { return s_lucky; }
        }

        private static readonly UnifiedAchievement s_steadyHand = new UnifiedAchievement("SteadyHand",
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_TVOS)
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_GOOGLE
            ""
#elif !UNITY_EDITOR && UNITY_ANDROID && CLOUDONCE_AMAZON
            ""
#else
            "SteadyHand"
#endif
            );

        public static UnifiedAchievement SteadyHand
        {
            get { return s_steadyHand; }
        }

        public static readonly UnifiedAchievement[] All =
        {
            s_fullDeck,
            s_gambler,
            s_highRoller,
            s_lucky,
            s_steadyHand,
        };
    }
}
