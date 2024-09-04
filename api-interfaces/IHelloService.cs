using System;
using MagicOnion;

namespace Hello.Shared
{
  public interface IHelloService : IService<IHelloService>
  {
    UnaryResult<string> SayAsync(string mes);
  }

  public interface CreateAccount : IService<CreateAccount>
  {
    UnaryResult<string> CreateAccountAsync(string username);
  }
}
