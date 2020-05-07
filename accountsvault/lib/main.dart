import 'dart:ui';
import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/database/dao/Account.dart';
import 'package:accountsvault/models/Account.dart';
import 'package:accountsvault/screens/account/List.dart';
import 'package:flutter/material.dart';

// Criar o consumo da moto.
// Criar os valores dos rendimentos mensais com gráficos.
// Criar cotaçáo das ações.
// Criar notificações.
// Criar JI e exibir as notificações.
// Alterar o nome do aplicativo. (OneForAll?)

void main() {
  runApp(AccountsVaultApp());

  AccountDao().findAll().then((accounts) {
    //print(accounts.length);
    if (accounts.length <= 0) {
      _insertDefaultContent();
    }
  });
}

void _insertDefaultContent() {
  AccountDao().save(Account(
      null,
      'Enel',
      '',
      'marcelosr6@gmail.com',
      'Google Login',
      'Telefone: (11) 5511-5823\nE-mail: roneie@msn.com\nCPF: 34124292600\nInstalação: 0112739881'));
  AccountDao().save(Account(null, 'Ali Express', '', 'marcelomsr@hotmail.com',
      'Ali10155996Express', ''));
  AccountDao().save(Account(
      null, 'Atlas Quantum', '', 'marcelomsr@hotmail.com', '2389OpT45', ''));
  AccountDao().save(Account(
      null,
      'AlphaFM',
      'https://www.alphafm.com.br/promocoes?p=1',
      'marcelomsr',
      '10155Alpha',
      ''));
  AccountDao().save(Account(null, 'Americanas.com', 'www.americanas.com',
      'marcelomsr@hotmail.com', 'Kxyz1545', 'Cartão final 9135'));
  AccountDao()
      .save(Account(null, 'AME', '', 'marcelomsr@hotmail.com', '10155aMe', ''));
  AccountDao()
      .save(Account(null, 'B3', '', '35656558878', '101CeI55996\$', ''));
  AccountDao().save(Account(null, 'Banco Inter', '', '0001/4245137-0',
      '101265iN', 'Assinatura 15426587'));
  AccountDao().save(Account(null, 'Bra', '', '', '', 'Débito: 101559'));
  AccountDao().save(Account(null, 'Banggood', '', 'marcelomsr@hotmail.com',
      'Facebook', 'Senha: faa9e934'));
  AccountDao().save(Account(
      null, 'Bodybuilding', '', 'marcelomsr@hotmail.com', '10155bB#', ''));
  AccountDao().save(
      Account(null, 'BTG Pactual', '', 'marcelomsr@hotmail.com', '564831', ''));
  AccountDao().save(Account(
      null, 'Cabify', '', 'marcelomsr@hotmail.com', '10155996Cabi', ''));
  AccountDao().save(Account(null, 'Caixa', '', 'marcelomsr27', 'Cx53yK',
      'AssinaturaEletrônica: 271718 \nDébito: 2651 \nSílabas: Hu De Vi \nInternacional: 7536'));
  AccountDao()
      .save(Account(null, 'Câmera wi-fi', '', '', '', 'Senha RTSP 10155RTsp'));
  AccountDao().save(Account(null, 'Carteira de trabalho digital', '',
      '35656558878', '10155996cTpS', ''));
  AccountDao().save(Account(null, 'Casa das torneiras', '',
      'marcelomsr@hotmail.com', '10155996CT', ''));
  AccountDao().save(Account(null, 'CEI', '', '', 'IlneaR160*', ''));
  AccountDao().save(
      Account(null, 'Centauro', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(
      Account(null, 'Cinemark', 'App', 'marcelomsr@hotmail.com', '0k5tj6', ''));
  AccountDao().save(Account(null, 'CNH Digital', '', 'marcelomsr@hotmail.com',
      '10155996CnhDigital', ''));
  AccountDao().save(Account(null, 'Consul Suporte', '',
      'marcelomsr@hotmail.com', 'Consul10155996', ''));
  AccountDao().save(
      Account(null, 'Correios', '', 'marcelomsr15', '10155iDCorreio', ''));
  AccountDao().save(Account(
      null, 'Cripteryum', '', 'e-mail e celular', '101kxy', 'PIN 1853'));
  AccountDao().save(Account(null, 'Dafiti', 'www.dafiti.com.br',
      'marcelomsr@hotmail.com', '10155Dafiti', ''));
  AccountDao().save(Account(null, 'Dashlane', '', '', '', ''));
  AccountDao().save(Account(null, 'Daycoval', '', '00085816100', '10155265',
      'Código de segurança 26581 (Resposta pergunta secreta: Nami) banco 707 agencia 00019 conta corrente 000124684-6'));
  AccountDao().save(Account(null, 'Deezer', '', 'marcelomsr@hotmail.com',
      '10155996Deezer', 'Conexão principal é com o Facebook'));
  AccountDao().save(Account(
      null, 'Deezer Family', '', 'marcelosr6@gmail.com', 'dEEzer10155', ''));
  AccountDao().save(Account(null, 'Dermo Manipulações',
      'www.dermomanipulacoes.com.br/', 'marcelomsr@hotmail.com', 'rezx85', ''));
  AccountDao().save(Account(
      null, 'DogHero', '', 'marcelomsr@hotmail.com', '10155dOgherO', ''));
  AccountDao().save(Account(null, 'Duolingo', 'App', 'Facebook', '', ''));
  AccountDao().save(
      Account(null, 'Espaçolaser', 'App', 'marcelosr6@gmail.com', '', ''));
  AccountDao().save(Account(
      null, 'EventBrite', '', 'marcelosr6@gmail.com', '10155996EV', ''));
  AccountDao()
      .save(Account(null, 'Extrato FGTS', '', '35656558878', '10155996', ''));
  AccountDao().save(Account(
      null,
      'Extrato FGTS Juliana',
      '',
      '40299432840',
      '10155996',
      'Ano que começou na LBV: 2008 Ano que começou no IEJPN: 2014'));
  AccountDao().save(Account(
      null, 'Facebook', '', 'marcelomsr@hotmail.com', 'VamosCruzeiro2019', ''));
  AccountDao().save(Account(null, 'FastShop', '', '', '', ''));
  AccountDao()
      .save(Account(null, 'Futebol Card', '', 'marcelomsr', '10155996Msr', ''));
  AccountDao().save(Account(
      null,
      'Genial Investimentos',
      '',
      'marcelomsr@hotmail.com',
      '101386',
      'Agência 0001 CC 143644-3 Banco 278 - Genial Investimentos'));
  AccountDao()
      .save(Account(null, 'GitHub', '', 'marcelomsr', '10155996Git', ''));
  AccountDao()
      .save(Account(null, 'Gol', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      null, 'Google', '', 'marcelosr6@gmail.com', '#CruzeiroQuerido', ''));
  AccountDao().save(Account(null, 'Google BK Clan', '',
      'bkclan123456789@gmail.com', 'blablabla10155996', ''));
  AccountDao().save(Account(null, 'Google UserCoc', '',
      'user1coc2016@gmail.com', 'blablabla10155996', 'vai do 1 ao 8'));
  AccountDao().save(Account(null, 'Google2', '', 'marcelomsr56@gmail.com',
      'Cruzeiroquerido10155996', ''));
  AccountDao().save(Account(
      null, 'Gorila Shield', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao()
      .save(Account(null, 'Gympass', '', '35656558878', '10155GymPass', ''));
  AccountDao().save(Account(null, 'H2O Purificadores', '',
      'marcelomsr@hotmail.com', '10155996H2o', ''));
  AccountDao().save(Account(
      null, 'Habitacional', '', 'marcelomsr', '10155996Habitacional', ''));
  AccountDao().save(Account(null, 'ID Samsung TV 4 K', '',
      'marcelosr6@gmail.com', '10155996Samsung', ''));
  AccountDao().save(Account(null, 'iFood', '', 'marcelomsr@hotmail.com',
      '10155996iFood@', 'entregador senha 10155iFood'));
  AccountDao().save(Account(
      null, 'iFood Fleet', '', 'marcelomsr@hotmail.com', 'pQqAJ24e', ''));
  AccountDao().save(Account(
      null,
      'Ingresso.com',
      'App',
      'marcelomsr@hotmail.com',
      '10155ingR.CoM996',
      'Login também com o Facebook'));
  AccountDao()
      .save(Account(null, 'Initiative Q', '', 'Login do google', '', ''));
  AccountDao()
      .save(Account(null, 'Latam', '', '35656558878', '101Latam55996', ''));
  AccountDao().save(
      Account(null, 'Live TIM', '', '35656558878', '#CruzeiroQuerido2019', ''));
  AccountDao().save(
      Account(null, 'MadeiraMadeira', '', 'Login com o Facebook', '', ''));
  AccountDao().save(
      Account(null, 'Magazine Luiza', '', 'Login com o Facebook', '', ''));
  AccountDao().save(Account(null, 'Marin Brasil', '', 'marcelomsr@hotmail.com',
      '10155996MB', 'Revendedora Tramontina'));
  AccountDao().save(Account(null, 'Mastercard Surpreenda', '',
      'marcelomsr@hotmail.com', '10155996Surpreenda', ''));
  AccountDao().save(Account(null, 'Masterpass', '', 'marcelomsr@hotmail.com',
      '10155996MasterPass', ''));
  AccountDao().save(Account(null, 'Meliuz', '', 'marcelosr6@gmail.com',
      '10155Meluiz', 'Aplicativo 265732 cartão 3457'));
  AccountDao().save(Account(null, 'Mercado Bitcoin', '', '35656558878',
      '101mErcadoBitCoin', 'PIN 7319'));
  AccountDao().save(Account(
      null,
      'Mercado Livre',
      '',
      'marcelo.msr e marcelosr6@gmail.com',
      '10155996ML',
      '(CPF, e-mail, endereço LBV) Celular antigo (11) 9761-7379'));
  AccountDao().save(Account(null, 'Meu Tim', '', '11970408829', '5599', ''));
  AccountDao().save(Account(null, 'Meu Vivo', '', '35656558878', '154600', ''));
  AccountDao().save(Account(null, 'Microsoft', '', 'marcelomsr@hotmail.com',
      'VamosCruzeiroQuerido2019', ''));
  AccountDao()
      .save(Account(null, 'Multiplus', '', '35656558878', '10155muLti', ''));
  AccountDao().save(Account(
      null, 'Netshoes', '', 'marcelomsr@hotmail.com', '10155996Netshoes', ''));
  AccountDao()
      .save(Account(null, 'Next', '', 'marcelomsr@hotmail.com', '265155', ''));
  AccountDao().save(Account(
      null, 'Nintendo Network', '', 'marcelomsr@hotmail.com', '10155Nin', ''));
  AccountDao().save(
      Account(null, 'Nota Fiscal Paulista', '', '35656558878', '10155996', ''));
  AccountDao().save(Account(null, 'Nubank', 'www.nubank.com.br', '35656558878',
      'Cruzeiroquerido10155996kxy', ''));
  AccountDao().save(Account(null, 'Nuuvem', '', 'Login do google', '', ''));
  AccountDao().save(
      Account(null, 'OLX', '', 'marcelomsr@hotmail.com', '10155996Olx', ''));
  AccountDao().save(Account(null, 'Órama', '', 'marcelomsr@hotmail.com',
      '578613', 'Assinatura eletrônica: 10155oRama'));
  AccountDao().save(Account(
      null, 'PetLove', '', 'marcelomsr@hotmail.com', '10155PetLove', ''));
  AccountDao().save(Account(null, 'PicPay', '', 'marcelosr6@gmail.com', '2651',
      'picpay: marcelosr6'));
  AccountDao().save(Account(null, 'PicPay Ju', '', 'juuhdealmeida@gmail.com',
      '2651', 'picpay: juliana.caldeira94'));
  AccountDao().save(Account(null, 'Pinterest', '', 'marcelomsr@hotmail.com',
      'Pinterest10155996', ''));
  AccountDao().save(
      Account(null, 'Pokémon Company', '', 'marcelomsr@hotmail.com', '', ''));
  AccountDao().save(Account(null, 'Prime Cursos', 'www.primecursos.com.br',
      'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      null,
      'Primo Suplementos',
      'www.primosuplementos.com.br',
      'marcelomsr@hotmail.com',
      '10155996Primo',
      ''));
  AccountDao().save(Account(null, 'Promoção de embarque mastercard', '',
      'marcelomsr@hotmail.com', '10155996Surpreenda', ''));
  AccountDao().save(Account(null, 'Rappi entregador', 'App',
      'marcelomsr@hotmail.com', '101559raPPi', ''));
  AccountDao()
      .save(Account(null, 'RecargaPay Ju', '', 'Login do google', '', ''));
  AccountDao().save(Account(
      null, 'Reclame Aqui', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      null, 'Renda Fixa', 'App', 'marcelomsr@hotmail.com', '10155Rf', ''));
  AccountDao().save(Account(
      null, 'Ricardo Eletro', '', 'marcelomsr@hotmail.com', '7933', ''));
  AccountDao().save(Account(
      null, 'Riema', 'www.gruporiema.com.br', 'RI62LA4699', 'WO23FI', ''));
  AccountDao().save(Account(
      null,
      'Santader Esfera',
      'https://www.santanderesfera.com.br/',
      '35656558878',
      'Senha do cartão de crédito',
      ''));
  AccountDao().save(Account(
      null, 'Serasa Score', '', '35656558878', '10155996', 'Login Google'));
  AccountDao().save(
      Account(null, 'Shoptime', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(null, 'SmartMEI', 'https://web.smartmei.com.br',
      '35656558878', '10155sMartmEi', ''));
  AccountDao().save(Account(
      null, 'SmarttBot', '', 'marcelomsr@hotmail.com', '528kOtY01', ''));
  AccountDao().save(Account(null, 'Smiles', '', '35656558878', '1015', ''));
  AccountDao().save(Account(
      null,
      'Sócio Cruzeiro',
      'https://www.sociodofutebol.com.br/crusempre/www/login-maiordeminas-socio-do-futebol',
      'marcezeiro',
      '10155996vaizero',
      ''));
  AccountDao().save(Account(null, 'Sócio Rei', 'www.sociorei.com.br',
      'marcelomsr@hotmail.com', '', ''));
  AccountDao().save(Account(null, 'SportBay', 'www.sportbay.com.br',
      'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(null, 'Spotify', '', 'marcelomsr@hotmail.com',
      'Autenticação facebook', ''));
  AccountDao().save(Account(
      null, 'Spotify', '', 'marcelosr6@gmail.com', '10155996Spotify', ''));
  AccountDao().save(Account(null, 'Steam', '', 'marcelomsr', '10155996', ''));
  AccountDao().save(Account(
      null, 'Submarino', '', 'marcelomsr@hotmail.com', '10155996Subway', ''));
  AccountDao().save(Account(null, 'Terra Investimentos', '', '35656558878',
      '101tERraInV55\$', 'assinatura eletrônica: tE26\$54@'));
  AccountDao()
      .save(Account(null, 'Trigg', '', '35656558878', '10155triGG', ''));
  AccountDao()
      .save(Account(null, 'TudoAzul', '', '35656558878', '10155TudoAzul', ''));
  AccountDao().save(Account(null, 'TV Show Time', '', 'Facebook', '', ''));
  AccountDao().save(Account(
      null, 'Twitter', '', 'marcelomsr@hotmail.com', '10155996Twitter', ''));
  AccountDao().save(
      Account(null, 'Uber', '', 'marcelomsr@hotmail.com', '10155996Uber', ''));
  AccountDao().save(Account(null, 'Uber Motorista', '',
      'marcelomsr@hotmail.com', '10155996Uber', ''));
  AccountDao().save(Account(null, 'Vivo Easy', '', '', '101xyz', ''));
  AccountDao().save(Account(null, 'Xiaomi Account', '', 'marcelosr6@gmail.com',
      '10155996iMi', 'ID: 1853325070'));
  AccountDao().save(Account(
      null, 'WebMotors', '', 'marcelomsr@hotmail.com', '10155996WM', ''));
  AccountDao()
      .save(Account(null, 'c-sharcorner', '', 'login facebook', '', ''));
  AccountDao().save(Account(null, 'tremdepassageiros.vale.com', '',
      'marcelomsr@hotmail.com', '10133Vale', ''));
  AccountDao().save(
      Account(null, 'Apple', '', 'marcelosr6@gmail.com', '10155996Apple', ''));
  AccountDao().save(Account(null, 'www.amazon.com.br', '',
      'marcelomsr@hotmail.com', '9sgamazon.comopl851rtv', ''));
  AccountDao()
      .save(Account(null, 'Mercado Pago Meu', '', 'Login Google', '', ''));
  AccountDao().save(Account(null, 'Mercado Pago Juliana', '',
      'juuhdealmeida@gmail.com', 'juuh10155996', ''));
}

class AccountsVaultApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(
        brightness: Brightness.dark,
        primaryColor: Constants.colorApp,
        accentColor: Constants.colorApp,
        buttonTheme: ButtonThemeData(
          buttonColor: Constants.colorApp,
          textTheme: ButtonTextTheme.primary,
        ),
      ),
      home: ListAccounts(),
    );
  }
}
