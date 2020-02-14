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
  TextEditingController _controllerFieldName;
  TextEditingController _controllerFieldSite;
  TextEditingController _controllerFieldUser;
  TextEditingController _controllerFieldPassword;
  TextEditingController _controllerFieldDescription;

  final AccountDao _dao = AccountDao();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(_titleAppBar)),
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Editor(
              controller: _controllerFieldName = TextEditingController(
                text: widget.account != null ? widget.account.name : '',
              ),
              label: _labelFieldName,
              tip: _tipFieldName,
            ),
            Editor(
              controller: _controllerFieldSite = TextEditingController(
                text: widget.account != null ? widget.account.site : '',
              ),
              label: _labelFieldSite,
              tip: _tipFieldSite,
            ),
            Editor(
              controller: _controllerFieldUser = TextEditingController(
                text: widget.account != null ? widget.account.user : '',
              ),
              label: _labelFieldUser,
              tip: _tipFieldUser,
            ),
            Editor(
              controller: _controllerFieldPassword = TextEditingController(
                text: widget.account != null ? widget.account.password : '',
              ),
              label: _labelFieldPassword,
              tip: _tipFieldPassword,
              //password: true,
            ),
            Editor(
              controller: _controllerFieldDescription = TextEditingController(
                text: widget.account != null ? widget.account.description : '',
              ),
              label: _labelFieldDescription,
              tip: _tipFieldDescription,
              maxLines: 5,
            ),
            RaisedButton(
              child: Text(_textoBotaoConfirmar),
              onPressed: () {
                _saveAccount(context, widget.account);
              },
            ),
          ],
        ),
      ),
    );
  }

  void _saveAccount(BuildContext context, Account account) {
    final String name = _controllerFieldName.text;
    final String site = _controllerFieldSite.text;
    final String user = _controllerFieldUser.text;
    final String password = _controllerFieldPassword.text;
    final String description = _controllerFieldDescription.text;

    if (name != null && user != null && password != null) {
      final int id = (account != null ? account.id : 0);
      final accountSaved = Account(id, name, site, user, password, description);

      Future<int> future;

      if (accountSaved.id != 0)
        future = _dao.update(accountSaved);
      else
        future = _dao.save(accountSaved);

      future.then((id) => Navigator.pop(context, accountSaved));
    }
  }
}
