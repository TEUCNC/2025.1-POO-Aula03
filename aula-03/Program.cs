using Xunit;

public class Televisao
{
    public float Tamanho { get; private set; }
    public int Volume { get; private set; }
    public bool Mudo { get; private set; }
    public int Canal { get; private set; }

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 10;
        Canal = 1;
        Mudo = false;
    }

    public void AumentarVolume()
    {
        if (!Mudo && Volume < 100) Volume++;
    }

    public void DiminuirVolume()
    {
        if (!Mudo && Volume > 0) Volume--;
    }

    public void AlternarModoMudo()
    {
        Mudo = !Mudo;
    }
    
    public void AumentarCanal()
    {
        Canal++;
    }

    public void DiminuirCanal()
    {
        if (Canal > 1) Canal--;
    }

    public void SelecionarCanal(int novoCanal)
    {
        if (novoCanal > 0) Canal = novoCanal;
    }
}

public class TelevisaoTests
{
    [Fact]
    public void Deve_Manter_Mudo_Ao_Tentar_Alterar_Volume()
    {
        var tv = new Televisao(42f);
        tv.AlternarModoMudo();
        tv.AumentarVolume();
        Assert.Equal(10, tv.Volume);
    }

    [Fact]
    public void Deve_Aumentar_Canal()
    {
        var tv = new Televisao(42f);
        tv.AumentarCanal();
        Assert.Equal(2, tv.Canal);
    }

    [Fact]
    public void Deve_Diminuir_Canal()
    {
        var tv = new Televisao(42f);
        tv.AumentarCanal();
        tv.DiminuirCanal();
        Assert.Equal(1, tv.Canal);
    }

    [Fact]
    public void Deve_Selecionar_Canal_Especifico()
    {
        var tv = new Televisao(42f);
        tv.SelecionarCanal(505);
        Assert.Equal(505, tv.Canal);
    }
}
