using CapiFiscal;


CupomFiscal cupom = new CupomFiscal("Santo antonio HortiFrutti", "12568945612578", "Lagoa Vos de Mares", 1092, "São Paulo", "SP");
cupom.AdicionarCsv("DataTeste.csv");
cupom.GerarCupom();

