﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet.Tests.Classes
{
    [TestClass]
    public class SubsystemSession_Disconnect_Connected
    {
        private Mock<ISession> _sessionMock;
        private Mock<IChannelSession> _channelMock;
        private string _subsystemName;
        private SubsystemSessionStub _subsystemSession;
        private int _operationTimeout;
        private IList<EventArgs> _disconnectedRegister;
        private IList<ExceptionEventArgs> _errorOccurredRegister;
        private MockSequence _sequence;

        [TestInitialize]
        public void Setup()
        {
            Arrange();
            Act();
        }

        protected void Arrange()
        {
            var random = new Random();
            _subsystemName = random.Next().ToString(CultureInfo.InvariantCulture);
            _operationTimeout = 30000;
            _disconnectedRegister = new List<EventArgs>();
            _errorOccurredRegister = new List<ExceptionEventArgs>();

            _sessionMock = new Mock<ISession>(MockBehavior.Strict);
            _channelMock = new Mock<IChannelSession>(MockBehavior.Strict);

            _sequence = new MockSequence();
            _sessionMock.InSequence(_sequence).Setup(p => p.CreateChannelSession()).Returns(_channelMock.Object);
            _channelMock.InSequence(_sequence).Setup(p => p.Open());
            _channelMock.InSequence(_sequence).Setup(p => p.SendSubsystemRequest(_subsystemName)).Returns(true);
            _channelMock.InSequence(_sequence).Setup(p => p.Dispose());

            _subsystemSession = new SubsystemSessionStub(
                _sessionMock.Object,
                _subsystemName,
                _operationTimeout);
            _subsystemSession.Disconnected += (sender, args) => _disconnectedRegister.Add(args);
            _subsystemSession.ErrorOccurred += (sender, args) => _errorOccurredRegister.Add(args);
            _subsystemSession.Connect();
        }

        protected void Act()
        {
            _subsystemSession.Disconnect();
        }

        [TestMethod]
        public void DisconnectHasNeverFired()
        {
            Assert.AreEqual(0, _disconnectedRegister.Count);
        }

        [TestMethod]
        public void ErrorOccurredHasNeverFired()
        {
            Assert.AreEqual(0, _errorOccurredRegister.Count);
        }

        [TestMethod]
        public void IsOpenShouldReturnFalse()
        {
            Assert.IsFalse(_subsystemSession.IsOpen);
        }

        [TestMethod]
        public void DisposeOnChannelShouldBeInvokedOnce()
        {
            _channelMock.Verify(p => p.Dispose(), Times.Once);
        }
    }
}
