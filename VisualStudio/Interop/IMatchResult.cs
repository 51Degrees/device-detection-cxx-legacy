﻿/* *********************************************************************
 * This Source Code Form is copyright of 51Degrees Mobile Experts Limited. 
 * Copyright 2015 51Degrees Mobile Experts Limited, 5 Charlotte Close,
 * Caversham, Reading, Berkshire, United Kingdom RG4 7BY
 * 
 * This Source Code Form is the subject of the following patent 
 * applications, owned by 51Degrees Mobile Experts Limited of 5 Charlotte
 * Close, Caversham, Reading, Berkshire, United Kingdom RG4 7BY: 
 * European Patent Application No. 13192291.6; and
 * United States Patent Application Nos. 14/085,223 and 14/085,301.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0.
 * 
 * If a copy of the MPL was not distributed with this file, You can obtain
 * one at http://mozilla.org/MPL/2.0/.
 * 
 * This Source Code Form is “Incompatible With Secondary Licenses”, as
 * defined by the Mozilla Public License, v. 2.0.
 * ********************************************************************* */

using System;
using System.Collections.Generic;

namespace FiftyOne.Mobile.Detection.Provider.Interop
{
    public interface IMatchResult : IDisposable
    {
        /// <summary>
        /// Returns the value for the property provided.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        string this[string propertyName] { get; }

        IList<string> getValues(string propertyName);
        IList<string> getValues(int propertyIndex);
        string getValue(string propertyName);
        string getValue(int propertyIndex);
        string DeviceId { get; }
        int Rank { get; }
        int Difference { get; }
        int Method { get; }
        string UserAgent { get; }
    }
}
