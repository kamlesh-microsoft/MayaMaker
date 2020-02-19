﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MayaMaker.Services.Managers;
using MayaMaker.Services.Writers;
using Microsoft.AspNetCore.Mvc;
using NHapi.Base.Model;

namespace MayaMaker.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageMakerController : ControllerBase
    {
        readonly IMessageManager _messageManager = null;
        readonly IMessageWriter _messageWriter = null;

        public MessageMakerController(IMessageManager messageManager, IMessageWriter messageWriter)
        {
            _messageManager = messageManager;
            _messageWriter = messageWriter;
        }

        [HttpGet(Name = "GetAll")]
        public async Task<List<IMessage>> GetAll()
        {
            var messages = await _messageManager.GetAllAdtMessages();
            _messageWriter.WriteAllMessages(messages);
            return messages;
        }

        [HttpGet]
        public async Task<List<IMessage>> Get()
        {
            var messages = await _messageManager.GetAdtMessagesForOneEncounter();
            _messageWriter.WriteAllMessages(messages);
            return messages;
        }
    }
}
