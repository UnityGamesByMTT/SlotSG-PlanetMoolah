using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

internal class SocketModel
{

    public PlayerData playerData;
    public UIData uIData;

    public InitGameData initGameData;

    public ResultGameData resultGameData;

    public int currentBetIndex=0;
    internal SocketModel(){

        this.playerData= new PlayerData();
        this.uIData= new UIData();
        this.initGameData= new InitGameData();
        this.resultGameData= new ResultGameData();
    }

}



[Serializable]
public class InitGameData
{
    public List<List<string>> Reel { get; set; }
    public List<List<int>> Lines { get; set; }
    public List<double> Bets { get; set; }
    public bool canSwitchLines { get; set; }
    public List<int> LinesCount { get; set; }
    public List<int> autoSpin { get; set; }
    public List<List<int>> lineData {get; set;}
    public List<List<int>> freeSpinData {get; set;}
}

[Serializable]
public class ResultGameData
{
    public List<List<int>> resultSymbols { get; set; }
    public List<Cascading> cascading{get; set;}
    public bool isFreeSpin {get; set;}
    public int freeSpinCount { get; set; }
    public double jackpot { get; set; }
}

[Serializable]
public class PlayerData
{
    public double Balance { get; set; }
    public double CurrentWining { get; set; }
}

[Serializable]
public class UIData
{
    public List<Symbol> symbols { get; set; }

}



[Serializable]
public class Symbol
{
    public int ID { get; set; }
    public string Name { get; set; }
    public JToken Multiplier { get; set;}
    public object defaultAmount { get; set; }
    public object symbolsCount { get; set; }
    public object increaseValue { get; set; }
    public object description { get; set; }
    public int freeSpin { get; set; }
}


[Serializable]
public class AuthTokenData
{
    public string cookie;
    public string socketURL;
    public string nameSpace; //BackendChanges
}

[Serializable]
public class Cascading
{

    public List<List<int>> symbolsToFill{get; set;}
    public List<List<string>> winingSymbols {get; set;}
    public List<int> lineToEmit{get; set;}
    public double currentWining{get; set;}


}
