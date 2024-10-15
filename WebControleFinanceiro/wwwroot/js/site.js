$(document).ready(function () {
    // Preencher Form Pagamento com dados ao Abrir Modal
    // alert('site.js está funcionando!');
    $('#paymentModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget);
        var modal = $(this);
        modal.find('#paymentAccountId').val(button.data('id'));
        modal.find('#paymentNome').val(button.data('name'));
        modal.find('#paymentValor').val(button.data('value'));
        modal.find('#paymentDataVencimento').val(button.data('duedate'));

        var today = new Date().toISOString().split('T')[0];
        modal.find('#paymentDataPagamento').val(today);

        setTimeout(() => $('#paymentDataPagamento').focus(), 500);
    });

    // Opção para deletar conta
    $('#deleteModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget); // Botão que abriu o modal
        var accountId = button.data('id'); // Extraindo dados do atributo data-id
        var accountName = button.data('name'); // Extraindo dados do atributo data-name
        var actionUrl = button.data('url'); // Obtendo a URL do botão
        var modal = $(this);

        modal.find('#modalAccountName').text(accountName);
        modal.find('#deleteAccountId').val(accountId); // Definindo o ID no campo oculto

        // Definindo a ação do formulário com a URL correta
        var form = modal.find('#deleteForm');
        form.attr('action', actionUrl); // Atribuindo a URL ao formulário
    });

    // Preencher Form Editar com dados da conta
    $('#editAccountModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget);
        var modal = $(this);
        modal.find('#editAccountId').val(button.data('id'));
        modal.find('#editNome').val(button.data('name'));
        modal.find('#editValor').val(button.data('value'));
        modal.find('#editDataVencimento').val(button.data('duedate'));

        setTimeout(() => $('#editNome').focus(), 500);
    });

    // Form Nova Conta - Preenche Data de Vencimento com data corrente
    $('#createAccountModal').on('shown.bs.modal', function () {
        $('#Nome').focus();
        $('#DataVencimento').val(new Date().toISOString().split('T')[0]);
    });

    // Limpar Form Nova Conta ao fechar
    $('#createAccountModal').on('hidden.bs.modal', function () {
        $('#createAccountForm')[0].reset();
    });

   $('#reopenAccountModal').on('shown.bs.modal', function (event) {
        var button = $(event.relatedTarget); // Botão que acionou o modal
        var accountId = button.data('id'); // Extrai info do data-* atributos
        var accountName = button.data('name');
        var accountValue = button.data('value');
        var dueDate = button.data('duedate');

        // Atualiza os campos do modal
        var modal = $(this);
        modal.find('#reopenAccountId').val(accountId);
        modal.find('#reopenAccountName').val(accountName);
        modal.find('#reopenAccountValue').val(accountValue);
        modal.find('#reopenAccountDuedate').val(dueDate);

        // Limpa o  campo de senha e coloca foco nele
        modal.find('#reopenAccountPassword').val('').focus();
    });

});
