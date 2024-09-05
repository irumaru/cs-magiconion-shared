using System;
using MagicOnion;

namespace Hello.Shared
{
  public interface IHelloService : IService<IHelloService>
  {
    UnaryResult<string> SayAsync(string mes);
  }

  public interface IAccountService : IService<IAccountService>
  {
    UnaryResult<string> CreateAccountAsync(string username);
  }
}
