import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/screens/account/list.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(AccountsVaultApp());
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
