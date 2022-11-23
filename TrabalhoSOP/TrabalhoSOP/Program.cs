using TrabalhoSOP.Domain;
using TrabalhoSOP.Services;
using System;

List<Frames> frames = new List<Frames> {
                                        new Frames(1, 5, new DateTimeOffset(new DateTime(2022, 1, 1)).ToUnixTimeMilliseconds(),
                                                         new DateTimeOffset(new DateTime(2022, 12, 31)).ToUnixTimeMilliseconds(),  true, true),
                                        new Frames(2, 7, new DateTimeOffset(new DateTime(2022, 5, 1)).ToUnixTimeMilliseconds(),
                                                         new DateTimeOffset(new DateTime(2022, 2, 1)).ToUnixTimeMilliseconds(), false, true),
                                        new Frames(3, 6, new DateTimeOffset(new DateTime(2022, 3, 1)).ToUnixTimeMilliseconds(),
                                                         new DateTimeOffset(new DateTime(2022, 1, 3)).ToUnixTimeMilliseconds(), false, false),
                                        new Frames(4, 2, new DateTimeOffset(new DateTime(2022, 2, 1)).ToUnixTimeMilliseconds(),
                                                         new DateTimeOffset(new DateTime(2022, 4, 1)).ToUnixTimeMilliseconds(), true, false)
                                       };

Ordenacao ordenacao = new Ordenacao(frames);

Console.WriteLine($"FIFO: {ordenacao.OrdernarListaFifo().ToString()} \n");
Console.WriteLine($"LFU: {ordenacao.OrdernarListaLfu().ToString()} \n");
Console.WriteLine($"LRU: {ordenacao.OrdernarListaLru().ToString()} \n");
Console.WriteLine($"NRU: {ordenacao.OrdenarListaNru().ToString()} \n");
