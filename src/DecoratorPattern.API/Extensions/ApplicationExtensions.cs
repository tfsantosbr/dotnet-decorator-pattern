using System.Diagnostics;
using DecoratorPattern.API.Application.Common.Decorators;
using DecoratorPattern.API.Application.Common.Handlers;
using DecoratorPattern.API.Application.Features.Users.Handlers;
using FluentValidation;

namespace DecoratorPattern.API.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // validator

        services.AddValidatorsFromAssemblyContaining<CreateUserCommandResponse>();

        // add handlers (forma automática com a lib Scrutor)
        // AddHandlersAutomaticaly(services);

        // add handlers (forma manual)
        AddHandlersNative(services);

        return services;
    }

    private static void AddHandlersAutomaticaly(IServiceCollection services)
    {
        var watch = Stopwatch.StartNew();

        // Registra o handler e aplica os decorators para o CreateUserCommand
        services.AddScoped<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, CreateUserCommandHandler>();
        services.Decorate<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, ValidationDecorator<CreateUserCommand, CreateUserCommandResponse>>();
        services.Decorate<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>, LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>>();

        // Registra o handler e aplica os decorators para o UpdateUserCommand
        services.AddScoped<ICommandHandler<UpdateUserCommand>, UpdateUserCommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserCommand>, ValidationDecorator<UpdateUserCommand>>();
        services.Decorate<ICommandHandler<UpdateUserCommand>, LoggingDecorator<UpdateUserCommand>>();

        // Registra o handler e aplica os decorators para o RemoveUserCommand
        services.AddScoped<ICommandHandler<RemoveUserCommand>, RemoveUserCommandHandler>();
        services.Decorate<ICommandHandler<RemoveUserCommand>, ValidationDecorator<RemoveUserCommand>>();
        services.Decorate<ICommandHandler<RemoveUserCommand>, LoggingDecorator<RemoveUserCommand>>();

        services.AddScoped<ICommandHandler<UpdateUserTest1Command>, UpdateUserTest1CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest1Command>, ValidationDecorator<UpdateUserTest1Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest1Command>, LoggingDecorator<UpdateUserTest1Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest2Command>, UpdateUserTest2CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest2Command>, ValidationDecorator<UpdateUserTest2Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest2Command>, LoggingDecorator<UpdateUserTest2Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest3Command>, UpdateUserTest3CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest3Command>, ValidationDecorator<UpdateUserTest3Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest3Command>, LoggingDecorator<UpdateUserTest3Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest4Command>, UpdateUserTest4CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest4Command>, ValidationDecorator<UpdateUserTest4Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest4Command>, LoggingDecorator<UpdateUserTest4Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest5Command>, UpdateUserTest5CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest5Command>, ValidationDecorator<UpdateUserTest5Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest5Command>, LoggingDecorator<UpdateUserTest5Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest6Command>, UpdateUserTest6CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest6Command>, ValidationDecorator<UpdateUserTest6Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest6Command>, LoggingDecorator<UpdateUserTest6Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest7Command>, UpdateUserTest7CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest7Command>, ValidationDecorator<UpdateUserTest7Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest7Command>, LoggingDecorator<UpdateUserTest7Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest8Command>, UpdateUserTest8CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest8Command>, ValidationDecorator<UpdateUserTest8Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest8Command>, LoggingDecorator<UpdateUserTest8Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest9Command>, UpdateUserTest9CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest9Command>, ValidationDecorator<UpdateUserTest9Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest9Command>, LoggingDecorator<UpdateUserTest9Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest10Command>, UpdateUserTest10CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest10Command>, ValidationDecorator<UpdateUserTest10Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest10Command>, LoggingDecorator<UpdateUserTest10Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest11Command>, UpdateUserTest11CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest11Command>, ValidationDecorator<UpdateUserTest11Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest11Command>, LoggingDecorator<UpdateUserTest11Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest12Command>, UpdateUserTest12CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest12Command>, ValidationDecorator<UpdateUserTest12Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest12Command>, LoggingDecorator<UpdateUserTest12Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest13Command>, UpdateUserTest13CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest13Command>, ValidationDecorator<UpdateUserTest13Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest13Command>, LoggingDecorator<UpdateUserTest13Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest14Command>, UpdateUserTest14CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest14Command>, ValidationDecorator<UpdateUserTest14Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest14Command>, LoggingDecorator<UpdateUserTest14Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest15Command>, UpdateUserTest15CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest15Command>, ValidationDecorator<UpdateUserTest15Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest15Command>, LoggingDecorator<UpdateUserTest15Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest16Command>, UpdateUserTest16CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest16Command>, ValidationDecorator<UpdateUserTest16Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest16Command>, LoggingDecorator<UpdateUserTest16Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest17Command>, UpdateUserTest17CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest17Command>, ValidationDecorator<UpdateUserTest17Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest17Command>, LoggingDecorator<UpdateUserTest17Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest18Command>, UpdateUserTest18CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest18Command>, ValidationDecorator<UpdateUserTest18Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest18Command>, LoggingDecorator<UpdateUserTest18Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest19Command>, UpdateUserTest19CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest19Command>, ValidationDecorator<UpdateUserTest19Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest19Command>, LoggingDecorator<UpdateUserTest19Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest20Command>, UpdateUserTest20CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest20Command>, ValidationDecorator<UpdateUserTest20Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest20Command>, LoggingDecorator<UpdateUserTest20Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest21Command>, UpdateUserTest21CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest21Command>, ValidationDecorator<UpdateUserTest21Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest21Command>, LoggingDecorator<UpdateUserTest21Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest22Command>, UpdateUserTest22CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest22Command>, ValidationDecorator<UpdateUserTest22Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest22Command>, LoggingDecorator<UpdateUserTest22Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest23Command>, UpdateUserTest23CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest23Command>, ValidationDecorator<UpdateUserTest23Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest23Command>, LoggingDecorator<UpdateUserTest23Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest24Command>, UpdateUserTest24CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest24Command>, ValidationDecorator<UpdateUserTest24Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest24Command>, LoggingDecorator<UpdateUserTest24Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest25Command>, UpdateUserTest25CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest25Command>, ValidationDecorator<UpdateUserTest25Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest25Command>, LoggingDecorator<UpdateUserTest25Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest26Command>, UpdateUserTest26CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest26Command>, ValidationDecorator<UpdateUserTest26Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest26Command>, LoggingDecorator<UpdateUserTest26Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest27Command>, UpdateUserTest27CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest27Command>, ValidationDecorator<UpdateUserTest27Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest27Command>, LoggingDecorator<UpdateUserTest27Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest28Command>, UpdateUserTest28CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest28Command>, ValidationDecorator<UpdateUserTest28Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest28Command>, LoggingDecorator<UpdateUserTest28Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest29Command>, UpdateUserTest29CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest29Command>, ValidationDecorator<UpdateUserTest29Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest29Command>, LoggingDecorator<UpdateUserTest29Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest30Command>, UpdateUserTest30CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest30Command>, ValidationDecorator<UpdateUserTest30Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest30Command>, LoggingDecorator<UpdateUserTest30Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest31Command>, UpdateUserTest31CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest31Command>, ValidationDecorator<UpdateUserTest31Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest31Command>, LoggingDecorator<UpdateUserTest31Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest32Command>, UpdateUserTest32CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest32Command>, ValidationDecorator<UpdateUserTest32Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest32Command>, LoggingDecorator<UpdateUserTest32Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest33Command>, UpdateUserTest33CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest33Command>, ValidationDecorator<UpdateUserTest33Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest33Command>, LoggingDecorator<UpdateUserTest33Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest34Command>, UpdateUserTest34CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest34Command>, ValidationDecorator<UpdateUserTest34Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest34Command>, LoggingDecorator<UpdateUserTest34Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest35Command>, UpdateUserTest35CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest35Command>, ValidationDecorator<UpdateUserTest35Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest35Command>, LoggingDecorator<UpdateUserTest35Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest36Command>, UpdateUserTest36CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest36Command>, ValidationDecorator<UpdateUserTest36Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest36Command>, LoggingDecorator<UpdateUserTest36Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest37Command>, UpdateUserTest37CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest37Command>, ValidationDecorator<UpdateUserTest37Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest37Command>, LoggingDecorator<UpdateUserTest37Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest38Command>, UpdateUserTest38CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest38Command>, ValidationDecorator<UpdateUserTest38Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest38Command>, LoggingDecorator<UpdateUserTest38Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest39Command>, UpdateUserTest39CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest39Command>, ValidationDecorator<UpdateUserTest39Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest39Command>, LoggingDecorator<UpdateUserTest39Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest40Command>, UpdateUserTest40CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest40Command>, ValidationDecorator<UpdateUserTest40Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest40Command>, LoggingDecorator<UpdateUserTest40Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest41Command>, UpdateUserTest41CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest41Command>, ValidationDecorator<UpdateUserTest41Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest41Command>, LoggingDecorator<UpdateUserTest41Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest42Command>, UpdateUserTest42CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest42Command>, ValidationDecorator<UpdateUserTest42Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest42Command>, LoggingDecorator<UpdateUserTest42Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest43Command>, UpdateUserTest43CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest43Command>, ValidationDecorator<UpdateUserTest43Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest43Command>, LoggingDecorator<UpdateUserTest43Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest44Command>, UpdateUserTest44CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest44Command>, ValidationDecorator<UpdateUserTest44Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest44Command>, LoggingDecorator<UpdateUserTest44Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest45Command>, UpdateUserTest45CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest45Command>, ValidationDecorator<UpdateUserTest45Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest45Command>, LoggingDecorator<UpdateUserTest45Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest46Command>, UpdateUserTest46CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest46Command>, ValidationDecorator<UpdateUserTest46Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest46Command>, LoggingDecorator<UpdateUserTest46Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest47Command>, UpdateUserTest47CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest47Command>, ValidationDecorator<UpdateUserTest47Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest47Command>, LoggingDecorator<UpdateUserTest47Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest48Command>, UpdateUserTest48CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest48Command>, ValidationDecorator<UpdateUserTest48Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest48Command>, LoggingDecorator<UpdateUserTest48Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest49Command>, UpdateUserTest49CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest49Command>, ValidationDecorator<UpdateUserTest49Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest49Command>, LoggingDecorator<UpdateUserTest49Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest50Command>, UpdateUserTest50CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest50Command>, ValidationDecorator<UpdateUserTest50Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest50Command>, LoggingDecorator<UpdateUserTest50Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest51Command>, UpdateUserTest51CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest51Command>, ValidationDecorator<UpdateUserTest51Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest51Command>, LoggingDecorator<UpdateUserTest51Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest52Command>, UpdateUserTest52CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest52Command>, ValidationDecorator<UpdateUserTest52Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest52Command>, LoggingDecorator<UpdateUserTest52Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest53Command>, UpdateUserTest53CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest53Command>, ValidationDecorator<UpdateUserTest53Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest53Command>, LoggingDecorator<UpdateUserTest53Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest54Command>, UpdateUserTest54CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest54Command>, ValidationDecorator<UpdateUserTest54Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest54Command>, LoggingDecorator<UpdateUserTest54Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest55Command>, UpdateUserTest55CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest55Command>, ValidationDecorator<UpdateUserTest55Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest55Command>, LoggingDecorator<UpdateUserTest55Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest56Command>, UpdateUserTest56CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest56Command>, ValidationDecorator<UpdateUserTest56Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest56Command>, LoggingDecorator<UpdateUserTest56Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest57Command>, UpdateUserTest57CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest57Command>, ValidationDecorator<UpdateUserTest57Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest57Command>, LoggingDecorator<UpdateUserTest57Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest58Command>, UpdateUserTest58CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest58Command>, ValidationDecorator<UpdateUserTest58Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest58Command>, LoggingDecorator<UpdateUserTest58Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest59Command>, UpdateUserTest59CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest59Command>, ValidationDecorator<UpdateUserTest59Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest59Command>, LoggingDecorator<UpdateUserTest59Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest60Command>, UpdateUserTest60CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest60Command>, ValidationDecorator<UpdateUserTest60Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest60Command>, LoggingDecorator<UpdateUserTest60Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest61Command>, UpdateUserTest61CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest61Command>, ValidationDecorator<UpdateUserTest61Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest61Command>, LoggingDecorator<UpdateUserTest61Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest62Command>, UpdateUserTest62CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest62Command>, ValidationDecorator<UpdateUserTest62Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest62Command>, LoggingDecorator<UpdateUserTest62Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest63Command>, UpdateUserTest63CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest63Command>, ValidationDecorator<UpdateUserTest63Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest63Command>, LoggingDecorator<UpdateUserTest63Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest64Command>, UpdateUserTest64CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest64Command>, ValidationDecorator<UpdateUserTest64Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest64Command>, LoggingDecorator<UpdateUserTest64Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest65Command>, UpdateUserTest65CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest65Command>, ValidationDecorator<UpdateUserTest65Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest65Command>, LoggingDecorator<UpdateUserTest65Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest66Command>, UpdateUserTest66CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest66Command>, ValidationDecorator<UpdateUserTest66Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest66Command>, LoggingDecorator<UpdateUserTest66Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest67Command>, UpdateUserTest67CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest67Command>, ValidationDecorator<UpdateUserTest67Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest67Command>, LoggingDecorator<UpdateUserTest67Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest68Command>, UpdateUserTest68CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest68Command>, ValidationDecorator<UpdateUserTest68Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest68Command>, LoggingDecorator<UpdateUserTest68Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest69Command>, UpdateUserTest69CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest69Command>, ValidationDecorator<UpdateUserTest69Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest69Command>, LoggingDecorator<UpdateUserTest69Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest70Command>, UpdateUserTest70CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest70Command>, ValidationDecorator<UpdateUserTest70Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest70Command>, LoggingDecorator<UpdateUserTest70Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest71Command>, UpdateUserTest71CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest71Command>, ValidationDecorator<UpdateUserTest71Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest71Command>, LoggingDecorator<UpdateUserTest71Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest72Command>, UpdateUserTest72CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest72Command>, ValidationDecorator<UpdateUserTest72Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest72Command>, LoggingDecorator<UpdateUserTest72Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest73Command>, UpdateUserTest73CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest73Command>, ValidationDecorator<UpdateUserTest73Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest73Command>, LoggingDecorator<UpdateUserTest73Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest74Command>, UpdateUserTest74CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest74Command>, ValidationDecorator<UpdateUserTest74Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest74Command>, LoggingDecorator<UpdateUserTest74Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest75Command>, UpdateUserTest75CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest75Command>, ValidationDecorator<UpdateUserTest75Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest75Command>, LoggingDecorator<UpdateUserTest75Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest76Command>, UpdateUserTest76CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest76Command>, ValidationDecorator<UpdateUserTest76Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest76Command>, LoggingDecorator<UpdateUserTest76Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest77Command>, UpdateUserTest77CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest77Command>, ValidationDecorator<UpdateUserTest77Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest77Command>, LoggingDecorator<UpdateUserTest77Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest78Command>, UpdateUserTest78CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest78Command>, ValidationDecorator<UpdateUserTest78Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest78Command>, LoggingDecorator<UpdateUserTest78Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest79Command>, UpdateUserTest79CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest79Command>, ValidationDecorator<UpdateUserTest79Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest79Command>, LoggingDecorator<UpdateUserTest79Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest80Command>, UpdateUserTest80CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest80Command>, ValidationDecorator<UpdateUserTest80Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest80Command>, LoggingDecorator<UpdateUserTest80Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest81Command>, UpdateUserTest81CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest81Command>, ValidationDecorator<UpdateUserTest81Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest81Command>, LoggingDecorator<UpdateUserTest81Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest82Command>, UpdateUserTest82CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest82Command>, ValidationDecorator<UpdateUserTest82Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest82Command>, LoggingDecorator<UpdateUserTest82Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest83Command>, UpdateUserTest83CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest83Command>, ValidationDecorator<UpdateUserTest83Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest83Command>, LoggingDecorator<UpdateUserTest83Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest84Command>, UpdateUserTest84CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest84Command>, ValidationDecorator<UpdateUserTest84Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest84Command>, LoggingDecorator<UpdateUserTest84Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest85Command>, UpdateUserTest85CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest85Command>, ValidationDecorator<UpdateUserTest85Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest85Command>, LoggingDecorator<UpdateUserTest85Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest86Command>, UpdateUserTest86CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest86Command>, ValidationDecorator<UpdateUserTest86Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest86Command>, LoggingDecorator<UpdateUserTest86Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest87Command>, UpdateUserTest87CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest87Command>, ValidationDecorator<UpdateUserTest87Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest87Command>, LoggingDecorator<UpdateUserTest87Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest88Command>, UpdateUserTest88CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest88Command>, ValidationDecorator<UpdateUserTest88Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest88Command>, LoggingDecorator<UpdateUserTest88Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest89Command>, UpdateUserTest89CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest89Command>, ValidationDecorator<UpdateUserTest89Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest89Command>, LoggingDecorator<UpdateUserTest89Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest90Command>, UpdateUserTest90CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest90Command>, ValidationDecorator<UpdateUserTest90Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest90Command>, LoggingDecorator<UpdateUserTest90Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest91Command>, UpdateUserTest91CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest91Command>, ValidationDecorator<UpdateUserTest91Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest91Command>, LoggingDecorator<UpdateUserTest91Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest92Command>, UpdateUserTest92CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest92Command>, ValidationDecorator<UpdateUserTest92Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest92Command>, LoggingDecorator<UpdateUserTest92Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest93Command>, UpdateUserTest93CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest93Command>, ValidationDecorator<UpdateUserTest93Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest93Command>, LoggingDecorator<UpdateUserTest93Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest94Command>, UpdateUserTest94CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest94Command>, ValidationDecorator<UpdateUserTest94Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest94Command>, LoggingDecorator<UpdateUserTest94Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest95Command>, UpdateUserTest95CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest95Command>, ValidationDecorator<UpdateUserTest95Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest95Command>, LoggingDecorator<UpdateUserTest95Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest96Command>, UpdateUserTest96CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest96Command>, ValidationDecorator<UpdateUserTest96Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest96Command>, LoggingDecorator<UpdateUserTest96Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest97Command>, UpdateUserTest97CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest97Command>, ValidationDecorator<UpdateUserTest97Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest97Command>, LoggingDecorator<UpdateUserTest97Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest98Command>, UpdateUserTest98CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest98Command>, ValidationDecorator<UpdateUserTest98Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest98Command>, LoggingDecorator<UpdateUserTest98Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest99Command>, UpdateUserTest99CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest99Command>, ValidationDecorator<UpdateUserTest99Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest99Command>, LoggingDecorator<UpdateUserTest99Command>>();

        services.AddScoped<ICommandHandler<UpdateUserTest100Command>, UpdateUserTest100CommandHandler>();
        services.Decorate<ICommandHandler<UpdateUserTest100Command>, ValidationDecorator<UpdateUserTest100Command>>();
        services.Decorate<ICommandHandler<UpdateUserTest100Command>, LoggingDecorator<UpdateUserTest100Command>>();

        watch.Stop();

        Console.WriteLine($"Handlers registered in {watch.ElapsedMilliseconds}ms");
    }

    private static void AddHandlersNative(IServiceCollection services)
    {
        var watch = Stopwatch.StartNew();

        services.AddScoped<CreateUserCommandHandler>();
        services.AddScoped<ICommandHandler<CreateUserCommand, CreateUserCommandResponse>>(provider =>
        {
            var handler = provider.GetRequiredService<CreateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>>>();
            var validator = provider.GetRequiredService<IValidator<CreateUserCommand>>();
            var validationDecorator = new ValidationDecorator<CreateUserCommand, CreateUserCommandResponse>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<CreateUserCommand, CreateUserCommandResponse>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserCommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserCommand>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserCommand>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserCommand>>();
            var validationDecorator = new ValidationDecorator<UpdateUserCommand>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserCommand>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<RemoveUserCommandHandler>();
        services.AddScoped<ICommandHandler<RemoveUserCommand>>(provider =>
        {
            var handler = provider.GetRequiredService<RemoveUserCommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<RemoveUserCommand>>>();
            var validationDecorator = new ValidationDecorator<RemoveUserCommand>(handler, logger);
            var loggingDecorator = new LoggingDecorator<RemoveUserCommand>(handler, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest1CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest1Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest1CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest1Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest1Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest1Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest1Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest2CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest2Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest2CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest2Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest2Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest2Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest2Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest3CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest3Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest3CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest3Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest3Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest3Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest3Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest4CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest4Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest4CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest4Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest4Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest4Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest4Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest5CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest5Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest5CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest5Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest5Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest5Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest5Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest6CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest6Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest6CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest6Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest6Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest6Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest6Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest7CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest7Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest7CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest7Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest7Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest7Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest7Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest8CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest8Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest8CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest8Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest8Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest8Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest8Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest9CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest9Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest9CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest9Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest9Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest9Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest9Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest10CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest10Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest10CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest10Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest10Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest10Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest10Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest11CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest11Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest11CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest11Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest11Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest11Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest11Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest12CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest12Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest12CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest12Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest12Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest12Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest12Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest13CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest13Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest13CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest13Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest13Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest13Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest13Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest14CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest14Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest14CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest14Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest14Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest14Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest14Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest15CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest15Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest15CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest15Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest15Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest15Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest15Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest16CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest16Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest16CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest16Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest16Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest16Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest16Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest17CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest17Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest17CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest17Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest17Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest17Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest17Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest18CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest18Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest18CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest18Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest18Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest18Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest18Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest19CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest19Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest19CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest19Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest19Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest19Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest19Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest20CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest20Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest20CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest20Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest20Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest20Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest20Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest21CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest21Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest21CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest21Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest21Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest21Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest21Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest22CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest22Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest22CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest22Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest22Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest22Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest22Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest23CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest23Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest23CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest23Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest23Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest23Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest23Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest24CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest24Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest24CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest24Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest24Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest24Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest24Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest25CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest25Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest25CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest25Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest25Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest25Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest25Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest26CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest26Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest26CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest26Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest26Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest26Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest26Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest27CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest27Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest27CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest27Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest27Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest27Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest27Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest28CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest28Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest28CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest28Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest28Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest28Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest28Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest29CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest29Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest29CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest29Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest29Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest29Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest29Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest30CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest30Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest30CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest30Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest30Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest30Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest30Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest31CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest31Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest31CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest31Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest31Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest31Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest31Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest32CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest32Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest32CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest32Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest32Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest32Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest32Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest33CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest33Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest33CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest33Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest33Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest33Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest33Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest34CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest34Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest34CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest34Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest34Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest34Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest34Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest35CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest35Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest35CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest35Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest35Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest35Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest35Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest36CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest36Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest36CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest36Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest36Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest36Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest36Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest37CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest37Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest37CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest37Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest37Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest37Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest37Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest38CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest38Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest38CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest38Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest38Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest38Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest38Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest39CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest39Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest39CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest39Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest39Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest39Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest39Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest40CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest40Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest40CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest40Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest40Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest40Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest40Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest41CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest41Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest41CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest41Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest41Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest41Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest41Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest42CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest42Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest42CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest42Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest42Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest42Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest42Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest43CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest43Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest43CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest43Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest43Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest43Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest43Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest44CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest44Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest44CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest44Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest44Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest44Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest44Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest45CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest45Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest45CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest45Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest45Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest45Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest45Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest46CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest46Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest46CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest46Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest46Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest46Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest46Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest47CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest47Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest47CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest47Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest47Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest47Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest47Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest48CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest48Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest48CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest48Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest48Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest48Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest48Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest49CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest49Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest49CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest49Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest49Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest49Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest49Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest50CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest50Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest50CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest50Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest50Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest50Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest50Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest51CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest51Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest51CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest51Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest51Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest51Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest51Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest52CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest52Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest52CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest52Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest52Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest52Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest52Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest53CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest53Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest53CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest53Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest53Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest53Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest53Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest54CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest54Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest54CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest54Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest54Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest54Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest54Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest55CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest55Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest55CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest55Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest55Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest55Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest55Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest56CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest56Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest56CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest56Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest56Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest56Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest56Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest57CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest57Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest57CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest57Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest57Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest57Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest57Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest58CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest58Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest58CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest58Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest58Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest58Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest58Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest59CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest59Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest59CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest59Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest59Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest59Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest59Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest60CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest60Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest60CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest60Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest60Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest60Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest60Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest61CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest61Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest61CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest61Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest61Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest61Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest61Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest62CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest62Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest62CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest62Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest62Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest62Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest62Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest63CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest63Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest63CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest63Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest63Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest63Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest63Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest64CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest64Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest64CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest64Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest64Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest64Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest64Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest65CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest65Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest65CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest65Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest65Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest65Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest65Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest66CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest66Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest66CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest66Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest66Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest66Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest66Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest67CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest67Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest67CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest67Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest67Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest67Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest67Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest68CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest68Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest68CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest68Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest68Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest68Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest68Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest69CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest69Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest69CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest69Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest69Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest69Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest69Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest70CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest70Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest70CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest70Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest70Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest70Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest70Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest71CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest71Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest71CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest71Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest71Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest71Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest71Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest72CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest72Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest72CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest72Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest72Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest72Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest72Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest73CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest73Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest73CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest73Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest73Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest73Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest73Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest74CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest74Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest74CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest74Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest74Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest74Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest74Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest75CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest75Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest75CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest75Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest75Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest75Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest75Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest76CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest76Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest76CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest76Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest76Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest76Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest76Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest77CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest77Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest77CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest77Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest77Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest77Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest77Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest78CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest78Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest78CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest78Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest78Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest78Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest78Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest79CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest79Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest79CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest79Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest79Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest79Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest79Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest80CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest80Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest80CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest80Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest80Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest80Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest80Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest81CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest81Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest81CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest81Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest81Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest81Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest81Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest82CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest82Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest82CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest82Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest82Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest82Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest82Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest83CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest83Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest83CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest83Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest83Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest83Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest83Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest84CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest84Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest84CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest84Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest84Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest84Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest84Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest85CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest85Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest85CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest85Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest85Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest85Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest85Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest86CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest86Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest86CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest86Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest86Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest86Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest86Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest87CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest87Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest87CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest87Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest87Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest87Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest87Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest88CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest88Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest88CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest88Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest88Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest88Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest88Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest89CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest89Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest89CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest89Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest89Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest89Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest89Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest90CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest90Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest90CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest90Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest90Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest90Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest90Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest91CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest91Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest91CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest91Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest91Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest91Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest91Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest92CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest92Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest92CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest92Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest92Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest92Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest92Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest93CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest93Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest93CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest93Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest93Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest93Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest93Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest94CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest94Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest94CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest94Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest94Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest94Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest94Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest95CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest95Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest95CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest95Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest95Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest95Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest95Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest96CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest96Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest96CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest96Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest96Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest96Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest96Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest97CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest97Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest97CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest97Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest97Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest97Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest97Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest98CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest98Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest98CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest98Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest98Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest98Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest98Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest99CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest99Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest99CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest99Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest99Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest99Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest99Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        services.AddScoped<UpdateUserTest100CommandHandler>();
        services.AddScoped<ICommandHandler<UpdateUserTest100Command>>(provider =>
        {
            var handler = provider.GetRequiredService<UpdateUserTest100CommandHandler>();
            var logger = provider.GetRequiredService<ILogger<LoggingDecorator<UpdateUserTest100Command>>>();
            var validator = provider.GetRequiredService<IValidator<UpdateUserTest100Command>>();
            var validationDecorator = new ValidationDecorator<UpdateUserTest100Command>(handler, logger, validator);
            var loggingDecorator = new LoggingDecorator<UpdateUserTest100Command>(validationDecorator, logger);

            return loggingDecorator;
        });

        watch.Stop();
        Console.WriteLine($"Handlers registered in {watch.ElapsedMilliseconds}ms");
    }
}
