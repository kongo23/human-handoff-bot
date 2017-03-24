﻿using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgentTransferBot
{
    public interface IUserToAgent
    {
        Task<bool> AgentTransferRequired(Activity message, CancellationToken cancellationToken);

        Task SendToAgent(Activity message, CancellationToken cancellationToken);

        Task<Agent> IntitiateConversationWithAgent(Activity message, CancellationToken cancellationToken);
    }
}
