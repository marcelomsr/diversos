import 'package:accountsvault/componentes/editor.dart';
import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:flutter/material.dart';

const _titleAppBar = 'Create Account';

const _labelFieldName = 'Name of account';
const _tipFieldName = 'Google';

const _labelFieldSite = 'Site';
const _tipFieldSite = 'www.google.com';

const _labelFieldUser = 'User';
const _tipFieldUser = 'blabla@organization.com';

const _labelFieldPassword = 'Password';
const _tipFieldPassword = '******';

const _labelFieldDescription = 'Description';
const _tipFieldDescription = 'My account for google services.';

const _textoBotaoConfirmar = 'Save';

class AccountForm extends StatefulWidget {
  final Account account;

  AccountForm(this.account);

  @override
  State<StatefulWidget> createState() => AccountFormState();
}

class AccountFormState extends State<AccountForm> {
  final TextEditingController _controllerFieldName = TextEditingController();
  final TextEditingController _controllerFieldSite = TextEditingController();
  final TextEditingController _controllerFieldUser = TextEditingController();
  final TextEditingController _controllerFieldPassword =
      TextEditingController();
  final TextEditingController _controllerFieldDescription =
      TextEditingController();

  final AccountDao _dao = AccountDao();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(_titleAppBar)),
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Editor(
              text: widget.account.name,
              controller: _controllerFieldName,
              label: _labelFieldName,
              tip: _tipFieldName,
            ),
            Editor(
              controller: _controllerFieldSite,
              label: _labelFieldSite,
              tip: _tipFieldSite,
            ),
            Editor(
              controller: _controllerFieldUser,
              label: _labelFieldUser,
              tip: _tipFieldUser,
            ),
            Editor(
              controller: _controllerFieldPassword,
              label: _labelFieldPassword,
              tip: _tipFieldPassword,
            ),
            Editor(
              controller: _controllerFieldDescription,
              label: _labelFieldDescription,
              tip: _tipFieldDescription,
            ),
            RaisedButton(
              child: Text(_textoBotaoConfirmar),
              onPressed: () => _createAccount(context),
            ),
          ],
        ),
      ),
    );
  }

  void _createAccount(BuildContext context) {
    final String name = _controllerFieldName.text;
    final String site = _controllerFieldSite.text;
    final String user = _controllerFieldUser.text;
    final String password = _controllerFieldPassword.text;
    final String description = _controllerFieldDescription.text;

    if (name != null && user != null && password != null) {
      final accountCreated =
          Account(0, name, site, user, password, description);
      _dao
          .save(accountCreated)
          .then((id) => Navigator.pop(context, accountCreated));
    }
  }
}
