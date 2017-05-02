# Track-Event-Manager
Exercício para treinar lógica, o objetivo é organizar os eventos dentro de cada track (dia) do evento.

Linguagem: C#
Tecnologia utilizada: .NET CORE

Para resolver o exercício eu resolvi criar as entidades abaixo: 

1) Event: representa os eventos que serão apresentados na conferência, criei um método para interpretar o nome do evento e obter os detalhes dele, essas informações nome e a duração vem juntas no nome de entrada.

2) Track: Representa o dia da conferência e todos os eventos que irão ocorrer. Pra organizar os horários defini que a manhã da conferência  possuía 180 min (3h) e a tarde 240 min (4h), após os eventos da manhã vem o almoço e depois do evento da tarde vem o networking.

3) ManagerTrack: Está é a classe responsável por gerenciar a criação das tracks da conferência e organizar qual evento vai ocorrer em qual horário (session), o da manhã ou tarde.
