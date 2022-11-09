using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.MediatorPattern
{
    internal class Component
    {
        private IMediator _mediator;
        public IMediator Mediator { protected get => _mediator; set => _mediator = value; }

        public Component(IMediator mediator = null)
        {
            _mediator = mediator;
        }


        



    }
}
