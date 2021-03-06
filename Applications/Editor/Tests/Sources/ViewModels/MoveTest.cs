﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
/* ------------------------------------------------------------------------- */
using Cube.FileSystem.TestService;
using Cube.Pdf.App.Editor;
using Cube.Xui.Mixin;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;

namespace Cube.Pdf.Tests.Editor.ViewModels
{
    /* --------------------------------------------------------------------- */
    ///
    /// MainTest
    ///
    /// <summary>
    /// Tests for editing operations of the MainViewModel class.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    [TestFixture]
    class MoveTest : ViewModelFixture
    {
        #region Tests

        /* ----------------------------------------------------------------- */
        ///
        /// MoveNext
        ///
        /// <summary>
        /// Executes the test for moving selected items.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void MoveNext() => Create("SampleRotation.pdf", "", 9, vm =>
        {
            var src = vm.Data.Images.ToList();
            src[1].IsSelected = true;
            src[3].IsSelected = true;
            src[8].IsSelected = true;
            Assert.That(Invoke(vm, () => vm.Ribbon.MoveNext.Command.Execute()), "Invoke");

            var dest = vm.Data.Images.ToList();
            Assert.That(dest.Count,               Is.EqualTo(9));
            Assert.That(dest[0].RawObject.Number, Is.EqualTo(1));
            Assert.That(dest[1].RawObject.Number, Is.EqualTo(3));
            Assert.That(dest[2].RawObject.Number, Is.EqualTo(2));
            Assert.That(dest[3].RawObject.Number, Is.EqualTo(5));
            Assert.That(dest[4].RawObject.Number, Is.EqualTo(4));
            Assert.That(dest[5].RawObject.Number, Is.EqualTo(6));
            Assert.That(dest[6].RawObject.Number, Is.EqualTo(7));
            Assert.That(dest[7].RawObject.Number, Is.EqualTo(8));
            Assert.That(dest[8].RawObject.Number, Is.EqualTo(9));
            for (var i = 0; i < dest.Count; ++i) Assert.That(dest[i].Index, Is.EqualTo(i));
        });

        /* ----------------------------------------------------------------- */
        ///
        /// MovePrevious
        ///
        /// <summary>
        /// Executes the test for moving selected items.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void MovePrevious() => Create("SampleRotation.pdf", "", 9, vm =>
        {
            var src = vm.Data.Images.ToList();
            src[0].IsSelected = true;
            src[3].IsSelected = true;
            src[6].IsSelected = true;
            Assert.That(Invoke(vm, () => vm.Ribbon.MovePrevious.Command.Execute()), "Invoke");

            var dest = vm.Data.Images.ToList();
            Assert.That(dest.Count,               Is.EqualTo(9));
            Assert.That(dest[0].RawObject.Number, Is.EqualTo(1));
            Assert.That(dest[1].RawObject.Number, Is.EqualTo(2));
            Assert.That(dest[2].RawObject.Number, Is.EqualTo(4));
            Assert.That(dest[3].RawObject.Number, Is.EqualTo(3));
            Assert.That(dest[4].RawObject.Number, Is.EqualTo(5));
            Assert.That(dest[5].RawObject.Number, Is.EqualTo(7));
            Assert.That(dest[6].RawObject.Number, Is.EqualTo(6));
            Assert.That(dest[7].RawObject.Number, Is.EqualTo(8));
            Assert.That(dest[8].RawObject.Number, Is.EqualTo(9));
            for (var i = 0; i < dest.Count; ++i) Assert.That(dest[i].Index, Is.EqualTo(i));
        });

        /* ----------------------------------------------------------------- */
        ///
        /// MoveNext_DragDrop
        ///
        /// <summary>
        /// Executes the test for moving selected items by Drag&amp;Drop.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void MoveNext_DragDrop() => Create("SampleRotation.pdf", "", 9, vm =>
        {
            var src = vm.Data.Images.ToList();
            var obj = new DragDropObject(1) { DropIndex = 4 };
            src[1].IsSelected = true;
            src[3].IsSelected = true;
            src[6].IsSelected = true;
            Assert.That(Invoke(vm, () => vm.InsertOrMove.Execute(obj)), "Invoke");

            var dest = vm.Data.Images.ToList();
            Assert.That(dest.Count,               Is.EqualTo(9));
            Assert.That(dest[0].RawObject.Number, Is.EqualTo(1));
            Assert.That(dest[1].RawObject.Number, Is.EqualTo(3));
            Assert.That(dest[2].RawObject.Number, Is.EqualTo(5));
            Assert.That(dest[3].RawObject.Number, Is.EqualTo(2));
            Assert.That(dest[4].RawObject.Number, Is.EqualTo(6));
            Assert.That(dest[5].RawObject.Number, Is.EqualTo(4));
            Assert.That(dest[6].RawObject.Number, Is.EqualTo(8));
            Assert.That(dest[7].RawObject.Number, Is.EqualTo(9));
            Assert.That(dest[8].RawObject.Number, Is.EqualTo(7));

            for (var i = 0; i < dest.Count; ++i) Assert.That(dest[i].Index, Is.EqualTo(i));
        });

        /* ----------------------------------------------------------------- */
        ///
        /// MovePrevious_DragDrop
        ///
        /// <summary>
        /// Executes the test for moving selected items by Drag&amp;Drop.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Test]
        public void MovePrevious_DragDrop() => Create("SampleRotation.pdf", "", 9, vm =>
        {
            var src = vm.Data.Images.ToList();
            var obj = new DragDropObject(6) { DropIndex = 3 };
            src[1].IsSelected = true;
            src[3].IsSelected = true;
            src[6].IsSelected = true;
            Assert.That(Invoke(vm, () => vm.InsertOrMove.Execute(obj)), "Invoke");

            var dest = vm.Data.Images.ToList();
            Assert.That(dest.Count,               Is.EqualTo(9));
            Assert.That(dest[0].RawObject.Number, Is.EqualTo(2));
            Assert.That(dest[1].RawObject.Number, Is.EqualTo(4));
            Assert.That(dest[2].RawObject.Number, Is.EqualTo(1));
            Assert.That(dest[3].RawObject.Number, Is.EqualTo(3));
            Assert.That(dest[4].RawObject.Number, Is.EqualTo(7));
            Assert.That(dest[5].RawObject.Number, Is.EqualTo(5));
            Assert.That(dest[6].RawObject.Number, Is.EqualTo(6));
            Assert.That(dest[7].RawObject.Number, Is.EqualTo(8));
            Assert.That(dest[8].RawObject.Number, Is.EqualTo(9));

            for (var i = 0; i < dest.Count; ++i) Assert.That(dest[i].Index, Is.EqualTo(i));
        });

        #endregion

        #region Others

        /* ----------------------------------------------------------------- */
        ///
        /// Invoke
        ///
        /// <summary>
        /// Invokes the specified action and wait for completion.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private bool Invoke(MainViewModel vm, Action action)
        {
            var cts = new CancellationTokenSource();
            vm.Data.Modified.PropertyChanged += (s, e) => cts.Cancel();
            action();
            return Wait.For(cts.Token);
        }

        #endregion
    }
}
