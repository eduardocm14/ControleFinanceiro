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
        var button = $(event.relatedTarget);
        var modal = $(this);
        modal.find('#modalAccountName').text(button.data('name'));
        modal.find('#modalAccountCode').text(button.data('code'));
        modal.find('#deleteAccountId').val(button.data('id'));

        var form = modal.find('#deleteForm');
        form.attr('action', '@Url.Page("Index", "Delete")');
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
});
