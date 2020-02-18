import 'dart:ui';

import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/account/list.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(AccountsVaultApp());

  AccountDao()
      .save(Account(8, 'AES Eletropaulo', '', '34124292600', '112739881', ''));
  AccountDao().save(Account(9, 'Ali Express', '', 'marcelomsr@hotmail.com',
      'Ali10155996Express', ''));
  AccountDao().save(Account(
      10, 'Atlas Quantum', '', 'marcelomsr@hotmail.com', '2389OpT45', ''));
  AccountDao().save(Account(
      11,
      'AlphaFM',
      'https://www.alphafm.com.br/promocoes?p=1',
      'marcelomsr',
      '10155Alpha',
      ''));
  AccountDao().save(Account(12, 'Americanas.com', 'www.americanas.com',
      'marcelomsr@hotmail.com', 'Kxyz1545', 'Cartão final 9135'));
  AccountDao()
      .save(Account(13, 'AME', '', 'marcelomsr@hotmail.com', '10155aMe', ''));
  AccountDao().save(Account(14, 'B3', '', '35656558878', '101CeI55996\$', ''));
  AccountDao().save(Account(15, 'Banco Inter', '', '0001/4245137-0',
      '101265iNter', 'Assinatura 15426587'));
  AccountDao().save(Account(16, 'Bra', '', '', '', 'Débito: 101559'));
  AccountDao().save(Account(17, 'Banggood', '', 'marcelomsr@hotmail.com',
      'Facebook', 'Senha: faa9e934'));
  AccountDao().save(Account(
      18, 'Bodybuilding', '', 'marcelomsr@hotmail.com', '10155bB#', ''));
  AccountDao().save(
      Account(19, 'BTG Pactual', '', 'marcelomsr@hotmail.com', '564831', ''));
  AccountDao().save(
      Account(20, 'Cabify', '', 'marcelomsr@hotmail.com', '10155996Cabi', ''));
  AccountDao().save(Account(21, 'Caixa', '', 'marcelomsr27', 'Cx53yK',
      'AssinaturaEletrônica: 271718 \nDébito: 2651 \nSílabas: Hu De Vi \nSenha RTSP 10155RTsp'));
  AccountDao().save(Account(22, 'Câmera wi-fi', '', '', '', ''));
  AccountDao().save(Account(23, 'Carteira de trabalho digital', '',
      '35656558878', '10155996cTpS', ''));
  AccountDao().save(Account(24, 'Casa das torneiras', '',
      'marcelomsr@hotmail.com', '10155996CT', ''));
  AccountDao().save(Account(25, 'CEI', '', '', 'IlneaR160*', ''));
  AccountDao().save(
      Account(26, 'Centauro', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(27, 'Central Uninove', 'www3.uninove.br/se/aluno',
      'User 1716200954', '144054', ''));
  AccountDao().save(
      Account(28, 'Cinemark', 'App', 'marcelomsr@hotmail.com', '0k5tj6', ''));
  AccountDao().save(Account(29, 'CNH Digital', '', 'marcelomsr@hotmail.com',
      '10155996CnhDigital', ''));
  AccountDao().save(Account(30, 'Consul Suporte', '', 'marcelomsr@hotmail.com',
      'Consul10155996', ''));
  AccountDao()
      .save(Account(31, 'Correios', '', 'marcelomsr15', '10155iDCorreio', ''));
  AccountDao().save(
      Account(32, 'Cripteryum', '', 'e-mail e celular', '101kxy', 'PIN 1853'));
  AccountDao().save(Account(33, 'Dafiti', 'www.dafiti.com.br',
      'marcelomsr@hotmail.com', '10155Dafiti', ''));
  AccountDao().save(Account(34, 'Dashlane', '', '', '', ''));
  AccountDao().save(Account(35, 'Daycoval', '', '00085816100', '10155265',
      'Código de segurança 26581 (Resposta pergunta secreta: Nami) banco 707 agencia 00019 conta corrente 000124684-6'));
  AccountDao().save(Account(36, 'Deezer', '', 'marcelomsr@hotmail.com',
      '10155996Deezer', 'Conexão principal é com o Facebook'));
  AccountDao().save(Account(
      37, 'Deezer Family', '', 'marcelosr6@gmail.com', 'dEEzer10155', ''));
  AccountDao().save(Account(38, 'Dermo Manipulações',
      'www.dermomanipulacoes.com.br/', 'marcelomsr@hotmail.com', 'rezx85', ''));
  AccountDao().save(
      Account(39, 'DogHero', '', 'marcelomsr@hotmail.com', '10155dOgherO', ''));
  AccountDao().save(Account(40, 'Duolingo', 'App', 'Facebook', '', ''));
  AccountDao()
      .save(Account(41, 'Espaçolaser', 'App', 'marcelosr6@gmail.com', '', ''));
  AccountDao().save(
      Account(42, 'EventBrite', '', 'marcelosr6@gmail.com', '10155996EV', ''));
  AccountDao()
      .save(Account(43, 'Extrato FGTS', '', '35656558878', '10155996', ''));
  AccountDao().save(Account(
      44,
      'Extrato FGTS Juliana',
      '',
      '40299432840',
      '10155996',
      'Ano que começou na LBV: 2008 Ano que começou no IEJPN: 2014'));
  AccountDao().save(Account(
      45, 'Facebook', '', 'marcelomsr@hotmail.com', 'VamosCruzeiro2019', ''));
  AccountDao().save(Account(46, 'FastShop', '', '', '', ''));
  AccountDao()
      .save(Account(47, 'Futebol Card', '', 'marcelomsr', '10155996Msr', ''));
  AccountDao().save(Account(
      48,
      'Genial Investimentos',
      '',
      'marcelomsr@hotmail.com',
      '101386',
      'Agência 0001 CC 143644-3 Banco 278 - Genial Investimentos'));
  AccountDao().save(Account(49, 'GitHub', '', 'marcelomsr', '10155996Git', ''));
  AccountDao().save(Account(50, 'GK', '', 'marcelo.msr', '10155996Gk', ''));
  AccountDao()
      .save(Account(51, 'Gol', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      52, 'Google', '', 'marcelosr6@gmail.com', '#CruzeiroQuerido', ''));
  AccountDao().save(Account(53, 'Google BK Clan', '',
      'bkclan123456789@gmail.com', 'blablabla10155996', ''));
  AccountDao().save(Account(54, 'Google UserCoc', '', 'user1coc2016@gmail.com',
      'blablabla10155996', 'vai do 1 ao 8'));
  AccountDao().save(Account(55, 'Google2', '', 'marcelomsr56@gmail.com',
      'Cruzeiroquerido10155996', ''));
  AccountDao().save(Account(
      56, 'Gorila Shield', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao()
      .save(Account(57, 'Gympass', '', '35656558878', '10155GymPass', ''));
  AccountDao().save(Account(58, 'H2O Purificadores', '',
      'marcelomsr@hotmail.com', '10155996H2o', ''));
  AccountDao().save(Account(
      59, 'Habitacional', '', 'marcelomsr', '10155996Habitacional', ''));
  AccountDao().save(Account(60, 'ID Samsung TV 4 K', '', 'marcelosr6@gmail.com',
      '10155996Samsung', ''));
  AccountDao().save(Account(61, 'iFood', '', 'marcelomsr@hotmail.com',
      '10155996iFood@', 'entregador senha 10155iFood'));
  AccountDao().save(
      Account(62, 'iFood Fleet', '', 'marcelomsr@hotmail.com', 'pQqAJ24e', ''));
  AccountDao().save(Account(63, 'Ingresso.com', 'App', 'marcelomsr@hotmail.com',
      '10155ingR.CoM996', 'Login também com o Facebook'));
  AccountDao().save(Account(64, 'Initiative Q', '', 'Login do google', '', ''));
  AccountDao()
      .save(Account(65, 'Latam', '', '35656558878', '101Latam55996', ''));
  AccountDao().save(
      Account(66, 'Live TIM', '', '35656558878', '#CruzeiroQuerido2019', ''));
  AccountDao()
      .save(Account(67, 'MadeiraMadeira', '', 'Login com o Facebook', '', ''));
  AccountDao()
      .save(Account(68, 'Magazine Luiza', '', 'Login com o Facebook', '', ''));
  AccountDao().save(Account(69, 'Marin Brasil', '', 'marcelomsr@hotmail.com',
      '10155996MB', 'Revendedora Tramontina'));
  AccountDao().save(Account(70, 'Mastercard Surpreenda', '',
      'marcelomsr@hotmail.com', '10155996Surpreenda', ''));
  AccountDao().save(Account(71, 'Masterpass', '', 'marcelomsr@hotmail.com',
      '10155996MasterPass', ''));
  AccountDao().save(
      Account(72, 'Meliuz', '', 'marcelosr6@gmail.com', '10155Meluiz', ''));
  AccountDao().save(Account(73, 'Mercado Bitcoin', '', '35656558878',
      '101mErcadoBitCoin', 'PIN 7319'));
  AccountDao().save(Account(
      74,
      'Mercado Livre',
      '',
      'marcelo.msr e marcelosr6@gmail.com',
      '10155996ML',
      '(CPF, e-mail, endereço LBV) Celular antigo (11) 9761-7379'));
  AccountDao().save(Account(75, 'Meu Tim', '', '11970408829', '5599', ''));
  AccountDao().save(Account(76, 'Meu Vivo', '', '35656558878', '154600', ''));
  AccountDao().save(Account(77, 'Microsoft', '', 'marcelomsr@hotmail.com',
      'VamosCruzeiroQuerido2019', ''));
  AccountDao()
      .save(Account(78, 'Multiplus', '', '35656558878', '10155muLti', ''));
  AccountDao().save(Account(
      79, 'Netshoes', '', 'marcelomsr@hotmail.com', '10155996Netshoes', ''));
  AccountDao()
      .save(Account(80, 'Next', '', 'marcelomsr@hotmail.com', '265155', ''));
  AccountDao().save(Account(
      81, 'Nintendo Network', '', 'marcelomsr@hotmail.com', '10155Nin', ''));
  AccountDao().save(
      Account(82, 'Nota Fiscal Paulista', '', '35656558878', '10155996', ''));
  AccountDao().save(Account(83, 'Nubank', 'www.nubank.com.br', '35656558878',
      'Cruzeiroquerido10155996kxy', ''));
  AccountDao().save(
      Account(84, 'OLX', '', 'marcelomsr@hotmail.com', '10155996Olx', ''));
  AccountDao().save(Account(85, 'Órama', '', 'marcelomsr@hotmail.com', '578613',
      'Assinatura eletrônica: 10155oRama'));
  AccountDao().save(
      Account(86, 'PetLove', '', 'marcelomsr@hotmail.com', '10155PetLove', ''));
  AccountDao().save(Account(
      87, 'PicPay', '', 'marcelosr6@gmail.com', '2651', 'picpay: marcelosr6'));
  AccountDao().save(Account(88, 'PicPay Ju', '', 'juuhdealmeida@gmail.com',
      '2651', 'picpay: juliana.caldeira94'));
  AccountDao().save(Account(
      89, 'Pinterest', '', 'marcelomsr@hotmail.com', 'Pinterest10155996', ''));
  AccountDao().save(
      Account(90, 'Pokémon Company', '', 'marcelomsr@hotmail.com', '', ''));
  AccountDao().save(Account(91, 'Prime Cursos', 'www.primecursos.com.br',
      'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      92,
      'Primo Suplementos',
      'www.primosuplementos.com.br',
      'marcelomsr@hotmail.com',
      '10155996Primo',
      ''));
  AccountDao().save(Account(93, 'Promoção de embarque mastercard', '',
      'marcelomsr@hotmail.com', '10155996Surpreenda', ''));
  AccountDao().save(Account(94, 'Rappi entregador', 'App',
      'marcelomsr@hotmail.com', '101559raPPi', ''));
  AccountDao()
      .save(Account(95, 'RecargaPay Ju', '', 'Login do google', '', ''));
  AccountDao().save(Account(
      96, 'Reclame Aqui', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(
      97, 'Renda Fixa', 'App', 'marcelomsr@hotmail.com', '10155Rf', ''));
  AccountDao().save(
      Account(98, 'Ricardo Eletro', '', 'marcelomsr@hotmail.com', '7933', ''));
  AccountDao().save(Account(
      99, 'Riema', 'www.gruporiema.com.br', 'RI62LA4699', 'WO23FI', ''));
  AccountDao().save(Account(
      100,
      'Santader Esfera',
      'https://www.santanderesfera.com.br/',
      '35656558878',
      'Senha do cartão de crédito',
      ''));
  AccountDao().save(Account(
      101, 'Serasa Score', '', '35656558878', '10155996', 'Login Google'));
  AccountDao().save(
      Account(102, 'Shoptime', '', 'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(103, 'SmartMEI', 'https://web.smartmei.com.br',
      '35656558878', '10155sMartmEi', ''));
  AccountDao().save(
      Account(104, 'SmarttBot', '', 'marcelomsr@hotmail.com', '528kOtY01', ''));
  AccountDao().save(Account(105, 'Smiles', '', '35656558878', '1015', ''));
  AccountDao().save(Account(
      106,
      'Sócio Cruzeiro',
      'https://www.sociodofutebol.com.br/crusempre/www/login-maiordeminas-socio-do-futebol',
      'marcezeiro',
      '10155996vaizero',
      ''));
  AccountDao().save(Account(107, 'Sócio Rei', 'www.sociorei.com.br',
      'marcelomsr@hotmail.com', '', ''));
  AccountDao().save(Account(108, 'SportBay', 'www.sportbay.com.br',
      'marcelomsr@hotmail.com', '10155996', ''));
  AccountDao().save(Account(109, 'Spotify', '', 'marcelomsr@hotmail.com',
      'Autenticação facebook', ''));
  AccountDao().save(Account(
      110, 'Spotify', '', 'marcelosr6@gmail.com', '10155996Spotify', ''));
  AccountDao().save(Account(111, 'Steam', '', 'marcelomsr', '10155996', ''));
  AccountDao().save(Account(
      112, 'Submarino', '', 'marcelomsr@hotmail.com', '10155996Subway', ''));
  AccountDao().save(
      Account(113, 'Swarm', '', 'marcelomsr@hotmail.com', 'Swarm10155996', ''));
  AccountDao().save(Account(114, 'Terra Investimentos', '', '35656558878',
      '101tERraInV55\$', 'assinatura eletrônica: tE26\$54@'));
  AccountDao().save(Account(115, 'Trigg', '', '35656558878', '10155triGG', ''));
  AccountDao()
      .save(Account(116, 'TudoAzul', '', '35656558878', '10155TudoAzul', ''));
  AccountDao().save(Account(117, 'TV Show Time', '', 'Facebook', '', ''));
  AccountDao().save(Account(
      118, 'Twitter', '', 'marcelomsr@hotmail.com', '10155996Twitter', ''));
  AccountDao().save(
      Account(119, 'Uber', '', 'marcelomsr@hotmail.com', '10155996Uber', ''));
  AccountDao().save(Account(
      120, 'Uber Motorista', '', 'marcelomsr@hotmail.com', '10155996Uber', ''));
  AccountDao().save(Account(121, 'Vivo Ease', '', '', '101xyz', ''));
  AccountDao().save(Account(122, 'Xiaomi Account', '', 'marcelosr6@gmail.com',
      '10155996iMi', 'ID: 1853325070'));
  AccountDao().save(Account(
      123, 'WebMotors', '', 'marcelomsr@hotmail.com', '10155996WM', ''));
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
