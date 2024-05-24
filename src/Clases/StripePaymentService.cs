using Stripe;
using System;
using System.Collections.Generic;

namespace pet4sitter.Clases
{
    public class StripePaymentService
    {
        public StripePaymentService()
        {
            StripeConfiguration.ApiKey = Data.stripePrivateKey;
        }
        public static bool ProcessPayment(decimal amount, string currency)
        {
            try
            {
                StripeConfiguration.ApiKey = Data.stripePrivateKey; // Reemplaza con tu clave secreta de Stripe

                var chargeOptions = new ChargeCreateOptions
                {
                    Amount = (long)(amount * 100), // Cantidad en centavos (1 euro = 100 centavos)
                    Currency = currency,
                    Description = "Descripción del pago",
                    Source = "tok_visa", // Usa un token de prueba
                };

                var chargeService = new ChargeService();
                Charge charge = chargeService.Create(chargeOptions);

                return charge.Status == "succeeded";
            }
            catch (StripeException ex)
            {
                Console.WriteLine($"Error procesando el pago: {ex.Message}");
                return false;
            }
        }

    }
}
