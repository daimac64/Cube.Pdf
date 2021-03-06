﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using Cube.Generics;
using Cube.Log;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cube.Pdf.App.Pinstaller.Debug
{
    /* --------------------------------------------------------------------- */
    ///
    /// DebugLogger
    ///
    /// <summary>
    /// Provides extended methods to put debug information.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public static class DebugLogger
    {
        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Service object.</param>
        /// <param name="action">User action.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this IInstallable src, Action action,
            [CallerMemberName] string method = null)
        {
            var status = "Success";
            var sw     = Stopwatch.StartNew();

            try { action(); }
            catch { status = "Failed"; throw; }
            finally { src.Put($"[{method}]", $"{status}", $"({sw.Elapsed})"); }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Port monitor object.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this PortMonitor src,
            [CallerMemberName] string method = null) => src.Put(
            $"[{method}]",
            $"{nameof(src.Name)}:{src.Name.Quote()}",
            $"{nameof(src.Exists)}:{src.Exists}",
            $"{nameof(src.CanInstall)}:{src.CanInstall()}",
            $"{nameof(src.Environment)}:{src.Environment.Quote()}",
            $"{nameof(src.FileName)}:{src.FileName.Quote()}",
            $"{nameof(src.Config)}:{src.Config.Quote()}",
            $"{nameof(src.TargetDirectory)}:{src.TargetDirectory.Quote()}"
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Port object.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this Port src,
            [CallerMemberName] string method = null) => src.Put(
            $"[{method}]",
            $"{nameof(src.Name)}:{src.Name.Quote()}",
            $"{nameof(src.Exists)}:{src.Exists}",
            $"{nameof(src.CanInstall)}:{src.CanInstall()}",
            $"{nameof(src.MonitorName)}:{src.MonitorName.Quote()}",
            $"{nameof(src.Environment)}:{src.Environment.Quote()}",
            $"{nameof(src.Application)}:{src.Application.Quote()}",
            $"{nameof(src.Arguments)}:[ {src.Arguments} ]",
            $"{nameof(src.Temp)}:{src.Temp.Quote()}",
            $"{nameof(src.WaitForExit)}:{src.WaitForExit}"
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Printer driver object.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this PrinterDriver src,
            [CallerMemberName] string method = null) => src.Put(
            $"[{method}]",
            $"{nameof(src.Name)}:{src.Name.Quote()}",
            $"{nameof(src.Exists)}:{src.Exists}",
            $"{nameof(src.CanInstall)}:{src.CanInstall()}",
            $"{nameof(src.MonitorName)}:{src.MonitorName.Quote()}",
            $"{nameof(src.Environment)}:{src.Environment.Quote()}",
            $"{nameof(src.FileName)}:{src.FileName.Quote()}",
            $"{nameof(src.Config)}:{src.Config.Quote()}",
            $"{nameof(src.Data)}:{src.Data.Quote()}",
            $"{nameof(src.Help)}:{src.Help.Quote()}",
            $"{nameof(src.Repository)}:{src.Repository.Quote()}",
            $"{nameof(src.TargetDirectory)}:{src.TargetDirectory.Quote()}",
            $"[ {string.Join(" ", src.Dependencies.Select(e => e.Quote()))} ]"
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Printer object.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this Printer src,
            [CallerMemberName] string method = null) => src.Put(
            $"[{method}]",
            $"{nameof(src.Name)}:{src.Name.Quote()}",
            $"{nameof(src.Exists)}:{src.Exists}",
            $"{nameof(src.CanInstall)}:{src.CanInstall()}",
            $"{nameof(src.ShareName)}:{src.ShareName.Quote()}",
            $"{nameof(src.DriverName)}:{src.DriverName.Quote()}",
            $"{nameof(src.PortName)}:{src.PortName.Quote()}",
            $"{nameof(src.Environment)}:{src.Environment.Quote()}"
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Service object.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this SpoolerService src,
            [CallerMemberName] string method = null) => src.Put(
            $"[{method}]",
            $"{nameof(src.Name)}:{src.Name.Quote()}",
            $"{nameof(src.Status)}:{src.Status}",
            $"{nameof(src.DisplayName)}:{src.DisplayName.Quote()}",
            $"{nameof(src.MachineName)}:{src.MachineName.Quote()}",
            $"{nameof(src.CanStop)}:{src.CanStop}",
            $"{nameof(src.Timeout)}:{src.Timeout}"
        );

        /* ----------------------------------------------------------------- */
        ///
        /// Log
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /// <param name="src">Service object.</param>
        /// <param name="action">User action.</param>
        /// <param name="method">Method name.</param>
        ///
        /* ----------------------------------------------------------------- */
        public static void Log(this SpoolerService src, Action action,
            [CallerMemberName] string method = null)
        {
            var prev = src.Status;
            var sw   = Stopwatch.StartNew();
            action();
            src.Put($"[{method}]", $"{prev} -> {src.Status}", $"({sw.Elapsed})");
        }

        #endregion

        #region Implementations

        /* ----------------------------------------------------------------- */
        ///
        /// Put
        ///
        /// <summary>
        /// Puts debug information to the log file.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private static void Put<T>(this T src, params string[] args) =>
            src.LogDebug(string.Join("\t", args));

        #endregion
    }
}
