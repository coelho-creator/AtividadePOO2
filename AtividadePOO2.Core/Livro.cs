namespace AtividadePOO2.Core;

public class Livro
{
    public Livro(string categoria, string titulo, int numPaginas, string autor, string genero, decimal preco, DateTime dataDeEmissao)
    {
        ValidarCategoria(categoria);
        ValidarTitulo(titulo);
        ValidarNumPaginas(numPaginas);
        ValidarAutor(autor);
        ValidarGenero(genero);
        ValidarPreco(preco);
        ValidarDataDeEmissao(dataDeEmissao);
    }
    
    public string Categoria { get; private set; }
    public string Titulo { get; private set; }
    public int NumPaginas  { get; private set; }
    public string Autor { get; private set; }
    public string Genero { get; private set; }
    public decimal Preco { get; private set; }
    public DateTime DataDeEmissao { get; private set; }

    private void ValidarCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
            throw new Exception("Categoria não pode estar vazio ou nulo!");
        
        Categoria = categoria;
    }

    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("Titulo não pode estar vazio ou nulo!");

        Titulo = titulo;
    }

    private void ValidarNumPaginas(int numPaginas)
    {
        if (numPaginas <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numPaginas), 
                "O número de páginas deve ser maior que zero.");
        }
        
        NumPaginas = numPaginas;
    }

    private void ValidarAutor(string autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("Autor não pode estar vazio ou nulo!");
        
        Autor = autor;
    }

    private void ValidarGenero(string genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("Gênero não pode estar vazio ou nulo!");
        
        Genero = genero;
    }

    private void ValidarPreco(decimal preco)
    {
        if (preco <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(preco), "O preço deve ser maior que zero.");
        }
        
        Preco = preco;
    }

    private void ValidarDataDeEmissao(DateTime dataDeEmissao)
    {
        if (dataDeEmissao == default(DateTime))
        {
            throw new ArgumentException("A data de emissão não pode ser vazia.", nameof(dataDeEmissao));
        }
        
        if (dataDeEmissao > DateTime.Now)
        {
            throw new ArgumentOutOfRangeException(nameof(dataDeEmissao), "A data de emissão não pode ser no futuro.");
        }
        
        DataDeEmissao = dataDeEmissao;
    }
}