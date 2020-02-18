import 'dart:ui';

import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/account/list.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(AccountsVaultApp());

  AccountDao()
      .save(Account(1, 'AES Eletropaulo', '', '34124292600', '112739881', ''));
  AccountDao().save(Account(2, 'Ali Express', '', 'marcelomsr@hotmail.com',
      'Ali10155996Express', ''));
  AccountDao().save(Account(
      3, 'Atlas Quantum', '', 'marcelomsr@hotmail.com', '2389OpT45', ''));
  AccountDao().save(Account(
      4,
      'AlphaFM',
      'https://www.alphafm.com.br/promocoes?p=1',
      'marcelomsr',
      '10155Alpha',
      ''));
  AccountDao().save(Account(5, 'Americanas.com', 'www.americanas.com',
      'marcelomsr@hotmail.com', 'Kxyz1545', ''));
  AccountDao()
      .save(Account(6, 'AME', '', 'marcelomsr@hotmail.com', '10155aMe', ''));
  AccountDao().save(Account(7, 'B3', '', '35656558878', '101CeI55996\$', ''));
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
