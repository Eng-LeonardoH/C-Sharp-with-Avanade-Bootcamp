int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"Realizar possível venda? {possivelVenda}");

if(quantidadeCompra == 0) {
    Console.WriteLine("Venda Inválida");
}
else if (possivelVenda) {
    Console.WriteLine("Venda Realizada");
}
else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}