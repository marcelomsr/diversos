//import 'package:accountsvault/models/account.dart';
import 'package:accountsvault/screens/account/list.dart';
//import 'package:accountsvault/database/app_database.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(AccountsVaultApp());
  //save(Account(0, '', '', '', '', ''));
}

class AccountsVaultApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      //theme: ThemeData.dark(),
      theme: ThemeData(
        brightness: Brightness.dark,
        primaryColor: Colors.green.shade900,
        accentColor: Colors.green.shade900,
        buttonTheme: ButtonThemeData(
          buttonColor: Colors.green.shade900,
          textTheme: ButtonTextTheme.primary,
        ),
      ),
      home: ListAccounts(),
    );
  }
}
