using System;
using System.Collections.Generic;

namespace Boom.SystemsApi
{
    public interface ISystemContainer
    {
        void Add<T>(Action<T> onSuccses);
    }

    public class SystemContainer : ISystemContainer
    {
        private readonly List<>

        public void Add<T>(Action<T> onSuccses)
        {
            throw new NotImplementedException();
        }
    }
}