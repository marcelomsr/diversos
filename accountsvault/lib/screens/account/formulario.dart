import 'package:accountsvault/Constants.dart';
import 'package:accountsvault/componentes/editor.dart';
import 'package:accountsvault/database/dao/account.dart';
import 'package:accountsvault/models/account.dart';
import 'package:flutter/material.dart';

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
      appBar: AppBar(title: Text(Constants.titleAppBarCreateAccount)),
      body: SingleChildScrollView(
        child: Column(
          children: <Widget>[
            Editor(
              controller: _controllerFieldName = TextEditingController(
                text: widget.account != null ? widget.account.name : '',
              ),
              label: Constants.labelFieldNameCreateAccount,
              tip: Constants.tipFieldNameCreateAccount,
            ),
            Editor(
              controller: _controllerFieldSite = TextEditingController(
                text: widget.account != null ? widget.account.site : '',
              ),
              label: Constants.labelFieldSiteCreateAccount,
              tip: Constants.tipFieldSiteCreateAccount,
            ),
            Editor(
              controller: _controllerFieldUser = TextEditingController(
                text: widget.account != null ? widget.account.user : '',
              ),
              label: Constants.labelFieldUserCreateAccount,
              tip: Constants.tipFieldUserCreateAccount,
            ),
            Editor(
              controller: _controllerFieldPassword = TextEditingController(
                text: widget.account != null ? widget.account.password : '',
              ),
              label: Constants.labelFieldPasswordCreateAccount,
              tip: Constants.tipFieldPasswordCreateAccount,
              //password: true,
            ),
            Editor(
              controller: _controllerFieldDescription = TextEditingController(
                text: widget.account != null ? widget.account.description : '',
              ),
              label: Constants.labelFieldDescriptionCreateAccount,
              tip: Constants.tipFieldDescriptionCreateAccount,
              maxLines: 5,
            ),
            RaisedButton(
              child: Text(Constants.textSaveButton),
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
