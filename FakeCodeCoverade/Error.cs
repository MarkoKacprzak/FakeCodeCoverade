﻿using System;

namespace FakeCodeCoverade
{
  public class Error
  {
    public Exception Exception { get; internal set; }
    public Type Type { get; internal set; }
    public object[] Parameters { get; internal set; }
    public string MethodName { get; internal set; }
  }
}