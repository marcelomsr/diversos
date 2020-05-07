import 'package:accountsvault/componentes/MessageDialog.dart';
import 'package:accountsvault/screens/Selic.dart';
import 'package:accountsvault/screens/account/List.dart';
import 'package:accountsvault/screens/investment/Price.dart';
import 'package:flutter/material.dart';

class Constants {
  static const version = 'Version 1.0.1';

  static const titleAppBarAccounts = 'Accounts';
  static const textNoNameAccounts = 'Ah';
  static const passwordCopied = 'Password copied.';
  static const unknownError = 'unknown error.';
  static const undo = 'Undo';
  static const loading = 'Loading..';
  static const titleAppBarCreateAccount = 'Create Account';
  static const titleAppBarEditAccount = 'Edit Account';
  static const tipFieldNameCreateAccount = 'Name of account';
  static const tipFieldSiteCreateAccount = 'Site';
  static const tipFieldUserCreateAccount = 'User';
  static const tipFieldPasswordCreateAccount = 'Password';
  static const tipFieldDescriptionCreateAccount = 'Description';
  static const textSaveButton = 'Save';
  static const titleAppBarSelic = 'Rate Selic';
  static const formatDate = 'dd/MM/yyyy';
  static const percentage = '%';
  static const about = 'About';
  static const close = 'Close';
  static const search = 'Search..';
  static const drawerHeader = 'Drawer Header';
  static const titleAppBarPrice = 'Price';
  static const rateSelic = 3;

  static Color colorApp = Colors.blue.shade500;
  static BorderRadius borderRadius = BorderRadius.circular(20.0);

  static Widget showDrawer(BuildContext context) {
    return Drawer(
      child: ListView(
        // Important: Remove any padding from the ListView.
        padding: EdgeInsets.zero,
        children: <Widget>[
          DrawerHeader(
            child: Text(Constants.drawerHeader),
            decoration: BoxDecoration(
              color: Colors.blue,
            ),
          ),
          ListTile(
            title: Text(Constants.titleAppBarAccounts),
            onTap: () {
              _goTo(context, ListAccounts());
            },
          ),
          ListTile(
            title: Text(Constants.titleAppBarSelic),
            onTap: () {
              _goTo(context, SelicView());
            },
          ),
          ListTile(
            title: Text(Constants.titleAppBarPrice),
            onTap: () {
              _goTo(context, ListPrices());
            },
          ),
          ListTile(
            title: Text(Constants.about),
            onTap: () {
              showDialog(
                context: context,
                builder: (BuildContext context) {
                  return MessageDialog(
                    title: Constants.about,
                    content: Constants.version,
                    textCloseButton: Constants.close,
                  );
                },
              );
            },
          ),
        ],
      ),
    );
  }

  static void _goTo(BuildContext context, var destiny) {
    Navigator.of(context).push(
      MaterialPageRoute(
        builder: (context) {
          return destiny;
        },
      ),
    );
  }
}
