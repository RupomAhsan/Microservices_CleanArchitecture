﻿using System.Collections.Generic;

namespace CleanArchitecture.Utility.Results;

public interface IResult
{
  IReadOnlyCollection<IResultError> Errors { get; }
  string Message { get; }

  bool Succeeded { get; }
}

public interface IResult<out T> : IResult
{
  T Data { get; }
}
